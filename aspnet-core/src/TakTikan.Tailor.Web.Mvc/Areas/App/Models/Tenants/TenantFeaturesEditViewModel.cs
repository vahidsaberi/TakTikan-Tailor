using Abp.AutoMapper;
using TakTikan.Tailor.MultiTenancy;
using TakTikan.Tailor.MultiTenancy.Dto;
using TakTikan.Tailor.Web.Areas.App.Models.Common;

namespace TakTikan.Tailor.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}