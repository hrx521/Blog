using Blog.Domain;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.Modularity;
using System;
using Microsoft.Extensions.DependencyInjection;
using Blog.Domain.Configurations;

namespace Blog.EntityFrameworkCore
{
    [DependsOn(typeof(BlogDomainModule),typeof(AbpEntityFrameworkCoreModule),typeof(AbpEntityFrameworkCoreSqlServerModule),typeof(AbpEntityFrameworkCorePostgreSqlModule))] 
    public class BlogFrameworkCoreModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BlogDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
            Configure<AbpDbContextOptions>(options=>
            {
                switch(AppSettings.EnableDb)
                {
                    case "SqlServer":
                        options.UseSqlServer();
                        break;
                    case "Postgresql":
                        options.UseNpgsql();
                        break;
                    default:
                        options.UseSqlServer();
                        break;
                }
            });
        }
    }
}
