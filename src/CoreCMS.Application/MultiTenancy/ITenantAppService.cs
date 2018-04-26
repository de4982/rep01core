using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CoreCMS.MultiTenancy.Dto;

namespace CoreCMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
