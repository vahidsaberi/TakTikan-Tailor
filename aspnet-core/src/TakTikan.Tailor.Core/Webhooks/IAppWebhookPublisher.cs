using System.Threading.Tasks;
using TakTikan.Tailor.Authorization.Users;

namespace TakTikan.Tailor.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
