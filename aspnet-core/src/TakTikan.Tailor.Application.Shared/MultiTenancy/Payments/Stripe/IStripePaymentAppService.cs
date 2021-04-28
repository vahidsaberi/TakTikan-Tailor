using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.MultiTenancy.Payments.Dto;
using TakTikan.Tailor.MultiTenancy.Payments.Stripe.Dto;

namespace TakTikan.Tailor.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}