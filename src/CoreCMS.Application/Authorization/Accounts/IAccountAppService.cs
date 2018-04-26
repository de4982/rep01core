using System.Threading.Tasks;
using Abp.Application.Services;
using CoreCMS.Authorization.Accounts.Dto;

namespace CoreCMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
