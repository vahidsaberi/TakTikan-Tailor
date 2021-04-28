using System.Collections.Generic;
using TakTikan.Tailor.Editions.Dto;
using TakTikan.Tailor.MultiTenancy.Payments;

namespace TakTikan.Tailor.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}