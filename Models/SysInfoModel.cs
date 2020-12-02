using AbpLib;
using System.Runtime.CompilerServices;

namespace H6_Site
{
    public class SysInfoModel
    {
        private double _avgDiskWrite;
        private double _avgMem;
        private double _avgCPU;
        private double _avgKBPerDisk;
        private double _avgNetworkUsage;

        private double _highestDiskWrite;
        private double _highestMem;
        private double _highestCPU;
        private double _highestKBPerDisk;
        private double _highestNetUsage;

        public double AvgDiskWrite { get { return _avgDiskWrite; } set { _avgDiskWrite = value.RoundUp(); } }
        public double AvgMem { get { return _avgMem; } set { _avgMem = value.RoundUp(); } }
        public double AvgCPU { get { return _avgCPU; } set { _avgCPU = value.RoundUp(); } }
        public double AvgKBPerDisk { get { return _avgKBPerDisk; } set { _avgKBPerDisk = value.RoundUp(); } }
        public double AvgNetworkUsage { get { return _avgNetworkUsage; } set { _avgNetworkUsage = value.RoundUp(); } }

        public double HighestDiskWrite { get { return _highestDiskWrite; } set { _highestDiskWrite = value.RoundUp(); } }
        public double HighestMem { get { return _highestMem; } set { _highestMem = value.RoundUp(); } }
        public double HighestCPU { get { return _highestCPU; } set { _highestCPU = value.RoundUp(); } }
        public double HighestKBPerDisk { get { return _highestKBPerDisk; } set { _highestKBPerDisk = value.RoundUp(); } }
        public double HighestNetUsage { get { return _highestNetUsage; } set { _highestNetUsage = value.RoundUp(); } }

        public int AvgQueryLength { get; set; }
        public int LongestQuery { get; set; }

        public int APICalls { get; set; }
        public int AvgInterval { get; set; }
    }
}
