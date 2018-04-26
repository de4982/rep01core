using System.Threading.Tasks;
using CoreCMS.Configuration.Dto;

namespace CoreCMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
