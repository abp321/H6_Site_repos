using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static H6_Site.GlobalObjects;
using System;
using AbpLib;
using AbpLib.Web;
using System.Collections.Generic;

namespace H6_Site.Controllers
{
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpPost("/api/Data/GetData")]
        public async IAsyncEnumerable<Dictionary<string, object>> GetData()
        {
            if (await Request.AuthenticationCheck())
            {
                DataModel data = await Request.DeserializeBody<DataModel>();

                await foreach (Dictionary<string, object> record in sql.GetRecordStream(data.Query))
                {
                    yield return record;
                }
            }
        }

        [HttpGet("/api/Data/GetItems")]
        public async Task<List<ItemModel>> GetItems()
        {
            List<ItemModel> list = new List<ItemModel>();
            if (await Request.AuthenticationCheck())
            {
                string query = "select ItemName,Price,fs.StoredFile from ItemDetails as details inner join FileStorage as fs on details.FileId = fs.FileId where ItemName != ''";
                await foreach (var n in sql.GetRecordStream(query))
                {
                    byte[] bytes = (byte[])n["StoredFile"] ?? Array.Empty<byte>();
                    ItemModel item = new ItemModel()
                    {
                        ItemName = n["ItemName"]?.ToString() ?? "",
                        Price = Convert.ToDouble(n["Price"]),
                        StoredFile = Convert.ToBase64String(bytes)
                    };
                    list.Add(item);
                }
            }
            return list;
        }

        [HttpGet("/api/Data/UserInfo")]
        public async Task<UserModel> GetProfilePicture()
        {
            UserModel m = new UserModel();
            if (await Request.AuthenticationCheck())
            {
                try
                {
                    int userId = await GetCurrentUserId(m.UserName);
                    if (userId != 0)
                    {
                        m = await sql.GetModel<UserModel>($"select * from UserInfo where UserId = {userId}");
                    }
                }
                catch (Exception err)
                {
                    await err.LogErrors("DataController", "GetProfilePicture");
                }
            }
            return m;
        }

        [HttpGet("/api/Data/GetSysInfo/{date}")]
        public async Task<SysInfoModel> GetSysInfo(string date)
        {
            return await Request.AuthenticationCheck() ? await sql.GetModel<SysInfoModel>($"EXEC sp_SysInfo @param = '{date}'") : new SysInfoModel();
        }

        [HttpPost("/api/Data/UserUpdate")]
        public async Task UserUpdate()
        {
            if (await Request.AuthenticationCheck())
            {
                try
                {
                    UserModel m = await Request.DeserializeBody<UserModel>();
                    int userId = await GetCurrentUserId(m.UserName);
                    if (userId != 0)
                    {
                        string query = $"select * from UserInfo where UserId = {userId}";
                        await sql.UpdateRecord(m, query, UserUpdateFilter, null);
                    }
                }
                catch (Exception err)
                {
                    await err.LogErrors("DataController", "UserUpdate");
                }
            }
        }

        [HttpPost("/api/Data/UploadFile/{name}/{owner}/{type}")]
        public async Task<int> UploadFile(string name,string owner, string type)
        {
            if (await Request.AuthenticationCheck())
            {
                try
                {
                    if (name.InvalidFile(out Exception custErr))
                    {
                        await custErr.LogErrors("DataController", "UploadFile");
                    }
                    else
                    {
                        string[] file = name.Split('.');
                        bool fileExists = await sql.CheckQuery($"select FileName from FileStorage where FileName = '{file[0]}' ");
                        byte[] bytes = await Request.Body.GetBytes();

                        FileStorageModel m = new FileStorageModel
                        {
                            FileName = file[0],
                            CreatedDateTime = DateTime.Now,
                            StoredFile = Convert.ToBase64String(bytes),
                            Size = bytes.Length,
                            Extension = file[1],
                            FileType = type ?? "Unkown",
                            OwnerName = owner ?? "Anonymous"
                        };

                        if (type == "Profile_Picture" && fileExists)
                        {
                            await sql.UpdateRecord(m, $"select * from FileStorage where OwnerName = '{m.OwnerName}' and FileName = '{m.FileName}' ", "StoredFile");
                            await sql.Execute($"Update FileStorage set FileType = 'New_Picture' where FileType = 'Profile_Picture' and OwnerName = '{m.OwnerName}' and FileName != '{m.FileName}'");
                            return -1;
                        }

                        if (fileExists)
                        {
                           return -2;
                        }
                        else
                        {
                           return await sql.InsertRecordReturnUK(m, "FileStorage", "StoredFile");
                        }
                    }
                }
                catch (Exception err)
                {
                    await err.LogErrors("DataController", "UploadFile");
                }
            }
            return 0;
        }

        [HttpPost("/api/Data/UpdateItemDetails/{fileId}")]
        public async Task UpdateItemDetails(string fileId)
        {
            ItemModel m = await Request.DeserializeBody<ItemModel>();
            await sql.UpdateRecord(m,$"select * from ItemDetails where FileId = {fileId}", new string[] { "StoredFile" },null);
        }
    }
}
