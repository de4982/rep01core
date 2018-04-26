using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CoreCMS.Configuration.Dto;

namespace CoreCMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CoreCMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
