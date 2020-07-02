using Blog.Domain;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.Modularity;
using System;

namespace Blog
{
    [DependsOn(typeof(BlogDomainModule),typeof(AbpEntityFrameworkCoreModule),typeof(AbpEntityFrameworkCoreSqlServerModule),typeof(AbpEntityFrameworkCorePostgreSqlModule))] 
    public class BlogFrameworkCoreModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
