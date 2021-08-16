using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PatientPortal.Models;
using PatientPortal.Data;
using Microsoft.Extensions.DependencyInjection;

namespace PatientPortal
    {
    public class Program
        {
        public static void Main(string[ ] args)
            {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
                {
                var services = scope.ServiceProvider;

                try
                    {
                    SeedData.Initialize(services);
                    }
                catch (Exception ex)
                    {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An Error has occured seeding the Database!");
                    }
                }
            host.Run();
            }

        public static IHostBuilder CreateHostBuilder(string[ ] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
