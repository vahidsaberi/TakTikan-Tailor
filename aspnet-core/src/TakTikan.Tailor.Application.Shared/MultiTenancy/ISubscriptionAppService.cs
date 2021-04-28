﻿using System.Threading.Tasks;
using Abp.Application.Services;

namespace TakTikan.Tailor.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
