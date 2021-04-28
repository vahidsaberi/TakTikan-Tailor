using Abp.AutoMapper;
using TakTikan.Tailor.Sessions.Dto;

namespace TakTikan.Tailor.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}