using System;

namespace H6_Site
{
    public class SysEventLogModel
    {
        public string MachineName { get; set; }
        public int Index { get; set; }
        public short CategoryNumber { get; set; }
        public string EntryType { get; set; }
        public long InstanceId { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public DateTime TimeGenerated { get; set; }
    }
}
