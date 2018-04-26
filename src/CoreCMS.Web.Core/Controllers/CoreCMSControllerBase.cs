using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CoreCMS.Controllers
{

    public abstract class CoreCMSControllerBase : AbpController
    {
        protected CoreCMSControllerBase()
        {
            LocalizationSourceName = CoreCMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
