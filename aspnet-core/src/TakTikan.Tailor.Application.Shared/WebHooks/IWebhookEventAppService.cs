using System.Threading.Tasks;
using Abp.Webhooks;

namespace TakTikan.Tailor.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
