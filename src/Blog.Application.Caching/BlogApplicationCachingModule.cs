using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Volo.Abp.Identity;

namespace Blog.Application.Caching
{
    [DependsOn(typeof(AbpCachingModule),typeof(Domain.BlogDomainModule))]
    public class BlogApplicationCachingModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
