using AbpLib.SQL;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AbpLib.Networking;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Components;

namespace H6_Site
{
    public static class GlobalObjects
    {
        //Bar chart specifications
        public const int barWidth = 30;
        public const int spaceX = 30;
        public const int spaceY = 20;
        public const int chartHeightPct = 250;
        public const int maxDataValPct = 100;

        public static readonly ConcurrentBag<int> ApiCalls = new ConcurrentBag<int>();

        public static readonly string[] UserLoginFilter = new string[] { "Email", "FirstName", "LastName", "ProfilePicture", "Admin", "UserName","UserPassword","Phone" };
        public static readonly string[] UserCreationFilter = new string[] { "Email", "FirstName", "LastName", "ProfilePicture","IP","LoginGuid","LastLogin","Phone" };
        public static readonly string[] UserUpdateFilter = new string[] { "UserName", "UserPassword", "Admin", "ProfilePicture", "IP", "LoginGuid","LastLogin" };

        public static readonly bool IsLocal = Environment.MachineName == "IT-ANDREAS";
        public static bool LocalSVCRunning;
        public static bool LoggingIsPaused;
        public static MarkupString LocalSVC_Status => LocalSVCRunning ? new MarkupString("<div class=\"ProfileHeader\" style=\"color: green;\">Local service is running</div>") :
                                                                        new MarkupString("<div class=\"ProfileHeader\" style=\"color: red;\">Local service is down</div>");
        public static readonly HttpClient client;

        public static int LocalSVC_Interval = 1000;

        private static string CN => IsLocal ? "Data Source=IT-ANDREAS;Initial Catalog=dummydb;Persist Security Info=True;User ID=sa;Password=password" : "Data Source=SQL_01;Initial Catalog=MaxiToysDB;Persist Security Info=True;User ID=sa;Password=Password2020!";

        public static readonly AbpSql sql = new AbpSql(CN);

        static GlobalObjects()
        {
            Uri uri = IsLocal ? new Uri("http://localhost/api/") : new Uri("http://maxitoys/api/");
            client = new HttpClient() { BaseAddress = uri };
            client.DefaultRequestHeaders.Add("MaxiToysKey", "D82Km!k?xTT");
        }

        public static async Task MAIL(string message, string subject = "MaxiToys Mail")
        {
            if(IsLocal) await message.SendMailAsync(subject);
        }

        public static async Task<int> GetCurrentUserId(string userName)
        {
            return await sql.GetValue<int>($"select top (1) UserId from Users where UserName = '{userName}' ");
        }
    }
}
