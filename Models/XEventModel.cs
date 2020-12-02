using System;

namespace H6_Site
{
    public class XEventModel
    {
        public string Statement { get; set; }
        public DateTime TimeStamp { get; set; }
        public long Duration { get; set; }
        public long RowsAffected { get; set; }
    }
}
