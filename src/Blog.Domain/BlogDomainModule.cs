using Volo.Abp.Identity;
using Volo.Abp.Modularity;


namespace Blog.Domain
{
    [DependsOn(typeof(AbpIdentityDomainModule),typeof(BlogDomainSharedModule))]
    public class BlogDomainModule : AbpModule
    {

    }
}
