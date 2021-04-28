using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.Editions.Dto;
using TakTikan.Tailor.MultiTenancy.Dto;

namespace TakTikan.Tailor.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}