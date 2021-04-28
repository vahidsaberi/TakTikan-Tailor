﻿using System.Threading.Tasks;
using Abp.Application.Services;
using TakTikan.Tailor.Configuration.Tenants.Dto;

namespace TakTikan.Tailor.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
