using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Blog.Domain.Configurations
{
    public class AppSettings
    {
        private static readonly IConfigurationRoot _config;

        static AppSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            builder.Build();
        }
        public static string EnableDb => _config["ConnectionStrings:Enable"];

        public static string ConnectionString => _config.GetConnectionString(EnableDb);
    }
}
