using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.Authorization.Users.Dto;

namespace TakTikan.Tailor.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
