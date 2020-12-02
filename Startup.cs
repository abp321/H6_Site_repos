using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace H6_Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddMvcCore().AddMvcOptions(x => x.MaxIAsyncEnumerableBufferLimit = 10000000);
            services.AddSingleton<UserStateContainer>();
            services.AddSingleton<System.Diagnostics.Stopwatch>();

            services.AddSingleton<IHostedService, RecureHostedService>();

            services.AddSingleton<UpdateInfo>();
            services.AddHostedService<UpdateInfoWorker>();
            services.AddSingleton<Communication>();
            services.AddHostedService<CommunicationWorker>();
            services.AddSingleton<ItemModel>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapControllers();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }

    public class RecureHostedService : IHostedService
    {
        private readonly Communication c;
        public RecureHostedService()
        {
            c = new Communication();
            c.OnCommunicateChangeAsync += StartAsync;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            c.OnCommunicateChangeAsync -= StartAsync;
            return Task.CompletedTask;
        }
    }
}
