using Microsoft.Extensions.Logging;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace loggingTeste
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            ILoggerFactory loggerFactory = new LoggerFactory()
                .AddConsole(Configuration.GetSection("Logging"))
                .AddDebug();

            
            //loggerFactory.AddConsole()
            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("teste cacildes");
            LogLevel logLevel = new LogLevel { };

            
            
            
            Console.ReadKey();
            
                
        }
    }
}
