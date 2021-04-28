using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
