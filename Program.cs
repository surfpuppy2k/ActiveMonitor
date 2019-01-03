using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

namespace ActiveMonitor
{
    public class Program
    {
        static string filePath = $"Activity.json";
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            string json = File.ReadAllText(filePath);
            var obj = JsonConvert.DeserializeObject(json);
            var activity = JsonConvert.DeserializeObject<ActivityTracking>(json);

            double totalDistance = activity.Activities.Sum(d => d.Distance);
            int numberOfDays = activity.Activities.Select(d => d.Date).Distinct().Count();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
