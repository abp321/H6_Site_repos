using AbpLib.Web;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static H6_Site.GlobalObjects;
using System;

namespace H6_Site.Controllers
{
    [ApiController]
    public class ValidationController : ControllerBase
    {
        [HttpPost("/api/Validation/CreateUser")]
        public async Task<string> CreateUser()
        {
            if (await Request.AuthenticationCheck())
            {
                string result;
                UserModel newUser = await Request.DeserializeBody<UserModel>();

                bool userExists = await sql.CheckQuery($"select top (1) UserName from Users where UserName = '{newUser.UserName}' ");
                if (!userExists)
                {
                    await sql.Execute($"EXEC sp_CreateUser @user_name = '{newUser.UserName}', @password = '{newUser.UserPassword}'");
                    result = "User was created";
                }
                else
                {
                    result = "User already exists";
                }
                return result;
            }
            return "";
        }

        [HttpPost("/api/Validation/UserLogin")]
        public async Task<UserModel> UserLogin()
        {
            UserModel user = new UserModel();
            if (await Request.AuthenticationCheck())
            {
                user = await Request.DeserializeBody<UserModel>();


                user = await sql.GetModel<UserModel>($"EXEC sp_UserLogin @user_name = '{user.UserName}', @password = '{user.UserPassword}'");
                user.LastLogin = DateTime.Now;
                user.IP = Request.GetIP();
                user.LoginGuid = Guid.NewGuid();

                if (!string.IsNullOrEmpty(user.UserName))
                {
                    int GetUID = await sql.GetValue<int>($"select UserInfo.UserId from Users inner join UserInfo on Users.UserId = UserInfo.UserId where UserName = '{user.UserName}' ");
                    await sql.UpdateRecord(user, $"select * from UserInfo where UserId = {GetUID}", UserLoginFilter, null);
                }
            }
            return user;
        }

        [HttpPost("/api/Validation/RemoveItem")]
        public async Task RemoveItem()
        {
            if (await Request.AuthenticationCheck())
            {
                ItemModel m = await Request.DeserializeBody<ItemModel>();
                int fileId = await sql.GetValue<int>($"select FileId from ItemDetails where ItemName = '{m.ItemName}'");
                await sql.Execute($"delete from FileStorage where FileId = {fileId}");
            }
        }
    }
}
