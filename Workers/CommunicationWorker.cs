using AbpLib;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static H6_Site.GlobalObjects;

namespace H6_Site
{
    public class CommunicationWorker : BackgroundService
    {
        private readonly Communication _communicate;

        public CommunicationWorker(Communication communicate)
        {
            _communicate = communicate;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(async () =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    if (!ApiCalls.IsEmpty)
                    {
                        List<int> list = new List<int>();
                        while (!ApiCalls.IsEmpty)
                        {
                            if (ApiCalls.TryTake(out int count))
                            {
                                list.Add(count);
                            }
                        }
                        await _communicate.SendValues(list.Sum(), stoppingToken);
                    }
                    await Task.Delay(1000, stoppingToken);
                    if (stoppingToken.IsCancellationRequested)
                    {
                        Exception custErr = new Exception("Background worker stopped: CommunicationWorker");
                        await custErr.LogErrors("CommunicationWorker", "ExecuteAsync");
                    }
                }
            },stoppingToken);
        }
    }
}
