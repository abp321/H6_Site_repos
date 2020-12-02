using System;

namespace H6_Site
{
    public class SysInfoLogModel
    {
        public double CurrentProcessorUsage { get; set; }
        public double CurrentMemoryUsage { get; set; }
        public double CurrentNetworkUsage { get; set; }
        public double AvgKBPerDiskWrite { get; set; }
        public int CurrentDiskUsage { get; set; }
        public int APICalls { get; set; }
        public int MeasureInterval { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
