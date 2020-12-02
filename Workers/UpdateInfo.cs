using System;
using static H6_Site.GlobalObjects;
using System.Threading.Tasks;
using AbpLib.Web;

namespace H6_Site
{
    public class UpdateInfo
    {
        public SysInfoModel AllValues;
        public SysInfoModel TodayValues;

        public async Task GetValues()
        {
            TodayValues = await client.DESERIALIZE<SysInfoModel>("Data/GetSysInfo/today");
            AllValues = await client.DESERIALIZE<SysInfoModel>("Data/GetSysInfo/all");

            AllValues.LongestQuery = AllValues.LongestQuery > 0 ? AllValues.LongestQuery / 1000 : 0;

            AllValues.AvgQueryLength = AllValues.AvgQueryLength > 0 ? AllValues.AvgQueryLength / 1000 : 0;
            OnInfoChangeAsync?.Invoke();
        }

        public event Func<Task> OnInfoChangeAsync;
    }
}
