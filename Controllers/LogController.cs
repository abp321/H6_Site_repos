using AbpLib;
using AbpLib.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static H6_Site.GlobalObjects;

namespace H6_Site.Controllers
{
    [ApiController]
    public class LogController : ControllerBase
    {
        [HttpPost("/api/Log/InputLog")]
        public async Task InputLog()
        {
            if (await Request.AuthenticationCheck())
            {
                LogModel plog = await Request.DeserializeBody<LogModel>();
                await sql.InsertRecord(plog, "Log");
            }
        }

        [HttpPost("/api/Log/InputQueryLog")]
        public async Task InputQueryLog()
        {
            if (await Request.AuthenticationCheck())
            {
                XEventModel xmodel = await Request.DeserializeBody<XEventModel>();
                await sql.InsertRecord(xmodel, "QueryLog");
            }
        }

        [HttpPost("/api/Log/InputSysLog")]
        public async Task InputSysLog()
        {
            if (await Request.AuthenticationCheck())
            {
                SysInfoLogModel slog = await Request.DeserializeBody<SysInfoLogModel>();
                await sql.InsertRecord(slog, "SysInfoLog");
            }
        }

        [HttpPost("/api/Log/InputEventLog")]
        public async Task InputEventLog()
        {
            if (await Request.AuthenticationCheck())
            {
                SysEventLogModel elog = await Request.DeserializeBody<SysEventLogModel>();
                await sql.InsertRecord(elog, "SysEventLog");
            }
        }

        [HttpPost("/api/Log/LogJsonData")]
        public async Task LogJsonData()
        {
            if (await Request.AuthenticationCheck())
            {
                JsonDataModel jmodel = await Request.DeserializeBody<JsonDataModel>();

                if (!jmodel.JsonString.StartsWith("{\"CaptureDateTime"))
                {
                    await sql.InsertRecord(jmodel, "JsonData");
                }
            }
        }
    }
}
