using System.Threading.Tasks;
using Abp.Application.Services;
using CoreCMS.Sessions.Dto;

namespace CoreCMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
