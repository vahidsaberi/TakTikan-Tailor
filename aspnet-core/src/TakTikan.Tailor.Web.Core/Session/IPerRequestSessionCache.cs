using System.Threading.Tasks;
using TakTikan.Tailor.Sessions.Dto;

namespace TakTikan.Tailor.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
