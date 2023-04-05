using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHostBuilder(args).Run();
        }

        public static IWebHost BuildWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
            .UseDefaultServiceProvider(options => options.ValidateScopes = false)
            .Build();

    }
}
