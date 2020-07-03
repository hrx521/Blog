using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Blog.EntityFrameworkCore;

namespace Blog.HttpApi.Hosting
{
    [DependsOn(typeof(AbpAspNetCoreMvcModule),typeof(AbpAutofacModule),typeof(BlogHttpApiModule),typeof(Swagger.BlogSwaggerModule),typeof(BlogFrameworkCoreModule))]
    public class BlogHttpApiHostingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            //base.OnApplicationInitialization(context);
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(enpoints => enpoints.MapControllers());
        }
    }
}
