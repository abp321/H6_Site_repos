using System;
using System.Threading;
using System.Threading.Tasks;
using AbpLib;
using Microsoft.Extensions.Hosting;
using static H6_Site.GlobalObjects;

namespace H6_Site
{
    public class UpdateInfoWorker : BackgroundService
    {
        private readonly UpdateInfo _info;

        public UpdateInfoWorker(UpdateInfo info)
        {
            _info = info;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(async () =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    await _info.GetValues();
                    await Task.Delay(LocalSVC_Interval, stoppingToken);

                    if (stoppingToken.IsCancellationRequested)
                    {
                        Exception custErr = new Exception("Background worker stopped: UpdateInfoWorker");
                        await custErr.LogErrors("UpdateInfoWorker", "ExecuteAsync");
                    }
                }
            },stoppingToken);

        }
    }
}