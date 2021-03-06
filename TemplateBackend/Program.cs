using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //public static int Main(string[] args)
        //{
        //    Log.Logger = new LoggerConfiguration()
        //        .MinimumLevel.Debug()
        //        .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
        //        .Enrich.FromLogContext()

        //        .CreateLogger();

        //    try
        //    {
        //        Log.Information("Starting web host");
        //        CreateHostBuilder(args).Build().Run();
        //        return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Fatal(ex, "Host terminated unexpectedly");
        //        return 1;
        //    }
        //    finally
        //    {
        //        Log.CloseAndFlush();
        //    }

        //}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
