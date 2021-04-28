using System.Collections.Generic;
using TakTikan.Tailor.Editions.Dto;
using TakTikan.Tailor.MultiTenancy.Payments;

namespace TakTikan.Tailor.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}