using Abp.Application.Services;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Logging.Dto;

namespace TakTikan.Tailor.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
