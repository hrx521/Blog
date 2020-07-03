using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Blog.EntityFrameworkCore;
using Blog.EntityFrameworkCore.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    [DependsOn(typeof(BlogFrameworkCoreModule))]
    public class BlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BlogMigrationsDbContext>();
        }
    }
}
