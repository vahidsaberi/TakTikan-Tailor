using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace TakTikan.Tailor.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
