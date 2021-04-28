using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.Configuration.Host.Dto;

namespace TakTikan.Tailor.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
