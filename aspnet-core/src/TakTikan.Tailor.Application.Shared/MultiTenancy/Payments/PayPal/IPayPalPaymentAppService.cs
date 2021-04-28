﻿using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.MultiTenancy.Payments.PayPal.Dto;

namespace TakTikan.Tailor.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
