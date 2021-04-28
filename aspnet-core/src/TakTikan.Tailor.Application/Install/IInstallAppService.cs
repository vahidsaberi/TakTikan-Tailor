using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.Install.Dto;

namespace TakTikan.Tailor.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}