using Microsoft.AspNetCore.Http;
using AbpLib;
using System.Threading.Tasks;
using System;
using static H6_Site.GlobalObjects;
using AbpLib.Web;
using Blazor.Extensions.Canvas.Canvas2D;
using System.Diagnostics;
using AbpLib.Networking;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using Microsoft.JSInterop;
using System.Threading;

namespace H6_Site
{
    public static class EXTENSIONS
    {
        private const string APIKEY = "MaxiToysKey";
        private const string APIVALUE = "D82Km!k?xTT";

        public static async Task<bool> AuthenticationCheck(this HttpRequest request)
        {
            if(!LoggingIsPaused) ApiCalls.Add(1);

            if (!request.Headers.ContainsKey(APIKEY) || !request.Headers.Values.Contains(APIVALUE))
            {
                Exception custErr = new Exception("Illegal API call attempted");
                await custErr.LogErrors("EXTENSIONS", "AuthenticationCheck");
                return false;
            }
            return true;
        }

        public static async Task SendReceit(this UserModel CurrentUser, List<ItemModel> basketList)
        {
            StringBuilder sb = new StringBuilder("Name\tPrice\r\n\r\n");
            foreach(ItemModel m in basketList)
            {
                sb.AppendLine($"{m.ItemName}\t{m.Price} DKK");
            }
            sb.Append($"Sum: {basketList.Sum(x=>x.Price)} DKK");

            await sb.ToString().SendMailAsync("New MaxiToys order",CurrentUser.Email);

        }

        public static async Task<bool> ContactLocalSVC(this string key, object value)
        {
            KeyValuePair<string, object> pair = new KeyValuePair<string, object>(key, value);
            string json = pair.SERIALIZE();
            return await json.SendPacket();
        }

        public static async Task LogErrors(this Exception err, string className, string method)
        {
            LogModel m = new LogModel
            {
                API = "MaxiToys Web site",
                Class = className,
                Method = method,
                Info = err.PropertyView(),
                CreatedDateTime = DateTime.Now,
                IsError = true,
                MS = 0.0D
            };
            await client.PostAsync("Log/InputLog", m.SERIALIZE_CONTENT());
        }

        public static async Task LogTime(this Stopwatch watch, string className, string method, string extraData = "")
        {
            watch.Stop();
            LogModel m = new LogModel
            {
                Class = className,
                Method = method,
                Info = extraData,
                CreatedDateTime = DateTime.Now,
                IsError = false,
                MS = watch.Elapsed.TotalMilliseconds.RoundUp(),
                API = "MaxiToys Web site"
            };
            await client.PostAsync("Log/InputLog", m.SERIALIZE_CONTENT());
            watch.Reset();
        }

        public static void InfoMsg(this IJSRuntime JS, string controlName, string msg, int delay = 3000)
        {
            ThreadPool.QueueUserWorkItem(async _ =>
            {
                if (delay != 0)
                {
                    await JS.InvokeVoidAsync("InfoFunction", controlName, msg, delay);
                }
                else
                {
                    await JS.InvokeVoidAsync("SetControlValue", controlName, msg);
                }
            });
        }

        public static bool InvalidFile(this string name, out Exception custErr)
        {
            switch (name)
            {
                case string a when !a.Contains('.'):
                    custErr = new Exception("File error: File name does not contain extension");
                    return true;
                case string a when string.IsNullOrEmpty(a):
                    custErr = new Exception("File error: File name is empty");
                    return true;
                default:
                    custErr = new Exception();
                    return false;
            }
        }

        public static bool CanDeserialize<T>(this string json)
        {
            try
            {
                T NewObject = json.DESERIALIZE<T>();

                return NewObject != null;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static string GetSqlFields(this Type t, params string[] exceptions)
        {
            IEnumerable<string> fields = t.GetProperties().Where(x=> !x.Name.ContainsAny(exceptions)).Select(x=> $"[{x.Name}]");
            return string.Join(',', fields);
        }

        public static string GetSearchStmt(this string[] fields, string search)
        {
            if (fields?.Length == 0 || string.IsNullOrEmpty(search)) return "";

            StringBuilder sb = new StringBuilder("where ");
            for (int i = 0; i < fields.Length; i++)
            {
                string field = fields[i];
                bool last = i == fields.Length - 1;
                string or = last ? "" : "or";
                sb.Append($"{field} like '%{search}%' {or} ");
            }
            return sb.ToString();
        }

        public static string GetSearchStmt(this string fields, string search)
        {
            if (string.IsNullOrEmpty(fields) || string.IsNullOrEmpty(search)) return "";

            string[] split = fields.Split(',');
            StringBuilder sb = new StringBuilder("where ");
            for (int i = 0; i < split.Length; i++)
            {
                string field = split[i];
                bool last = i == split.Length - 1;
                string or = last ? "" : "or";
                sb.Append($"{field} like '%{search}%' {or} ");
            }
            return sb.ToString();
        }

        public static void AddData(this Dictionary<string, Dictionary<string, object>[]> RecordSet, string table, Dictionary<string, object>[] records)
        {
            if (records == null) return;

            if (!RecordSet.ContainsKey(table))
            {
                RecordSet.Add(table, records);
            }
            else
            {
                RecordSet[table] = records;
            }
        }

        public static async Task DrawBar(this Canvas2DContext con, int barValue, string color, int xPos, int chartHeight)
        {
            await con.MoveToAsync(barWidth + xPos + spaceX, chartHeight - spaceY);
            await con.LineToAsync(barWidth + xPos + spaceX, chartHeight - spaceY);
            await con.StrokeAsync();

            int barHeight = -barValue * 2;

            await con.SetFillStyleAsync(color);
            await con.FillRectAsync(xPos + spaceX, chartHeight - spaceY - 1, barWidth, barHeight);

            await con.FillTextAsync(barValue.ToString(), xPos + spaceX + 5, chartHeight - spaceY + barHeight - 2);
            await con.SetFillStyleAsync(COLOR.Black);
        }

        public static async Task DrawBarsPctGraphs(this Canvas2DContext con, SysInfoModel m)
        {
            await con.DrawBar((int)m.AvgCPU, COLOR.Purple, 0, chartHeightPct);
            await con.DrawBar((int)m.HighestCPU, COLOR.DarkPurple, 30, chartHeightPct);

            await con.DrawBar((int)m.AvgMem, COLOR.Blue, 80, chartHeightPct);
            await con.DrawBar((int)m.HighestMem, COLOR.DarkBlue, 110, chartHeightPct);

            await con.DrawBar((int)m.AvgDiskWrite, COLOR.Green, 160, chartHeightPct);
            await con.DrawBar((int)m.HighestDiskWrite, COLOR.DarkGreen, 190, chartHeightPct);
        }
    }
}
