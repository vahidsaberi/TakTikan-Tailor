using Abp.AutoMapper;
using TakTikan.Tailor.MultiTenancy.Dto;

namespace TakTikan.Tailor.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
