using TakTikan.Tailor.Editions;
using TakTikan.Tailor.Editions.Dto;
using TakTikan.Tailor.MultiTenancy.Payments;
using TakTikan.Tailor.Security;
using TakTikan.Tailor.MultiTenancy.Payments.Dto;

namespace TakTikan.Tailor.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
