using TakTikan.Tailor.MultiTenancy.Payments;

namespace TakTikan.Tailor.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}