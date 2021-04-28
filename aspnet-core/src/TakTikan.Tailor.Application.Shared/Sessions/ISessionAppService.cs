using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.Sessions.Dto;

namespace TakTikan.Tailor.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
