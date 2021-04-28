using System.Collections.Generic;
using TakTikan.Tailor.Editions;
using TakTikan.Tailor.Editions.Dto;
using TakTikan.Tailor.MultiTenancy.Payments;
using TakTikan.Tailor.MultiTenancy.Payments.Dto;

namespace TakTikan.Tailor.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
