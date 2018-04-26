using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CoreCMS.Configuration;

namespace CoreCMS.Web.Host.Startup
{
    [DependsOn(
       typeof(CoreCMSWebCoreModule))]
    public class CoreCMSWebHostModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CoreCMSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreCMSWebHostModule).GetAssembly());
        }
    }
}
