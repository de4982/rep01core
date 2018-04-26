using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CoreCMS.Authorization;

namespace CoreCMS
{
    [DependsOn(
        typeof(CoreCMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CoreCMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CoreCMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CoreCMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
