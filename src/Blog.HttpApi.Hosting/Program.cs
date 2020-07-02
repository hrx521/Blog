using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System.Threading.Tasks;

namespace Blog.HttpApi.Hosting
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(builder =>
                {
                    builder
                    .UseIISIntegration()
                        .UseStartup<Startup>();
            }).UseAutofac().Build().RunAsync();
//            Log.Logger = new LoggerConfiguration()
//#if DEBUG
//                .MinimumLevel.Debug()
//#else
//                .MinimumLevel.Information()
//#endif
//                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
//                .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
//                .Enrich.FromLogContext()
//                .WriteTo.Async(c => c.File("Logs/logs.txt"))
//                .CreateLogger();

//            try
//            {
//                Log.Information("Starting web host.");
//                CreateHostBuilder(args).Build().Run();
//                return 0;
//            }
//            catch (Exception ex)
//            {
//                Log.Fatal(ex, "Host terminated unexpectedly!");
//                return 1;
//            }
//            finally
//            {
//                Log.CloseAndFlush();
//            }
        }

        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseAutofac()
                .UseSerilog();
    }
}
