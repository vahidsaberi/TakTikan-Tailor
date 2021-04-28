﻿using TakTikan.Tailor.Editions.Dto;

namespace TakTikan.Tailor.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < TailorConsts.MinimumUpgradePaymentAmount;
        }
    }
}
