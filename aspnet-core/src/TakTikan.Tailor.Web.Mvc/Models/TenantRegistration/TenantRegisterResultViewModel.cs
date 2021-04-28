using Abp.AutoMapper;
using TakTikan.Tailor.MultiTenancy.Dto;

namespace TakTikan.Tailor.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}