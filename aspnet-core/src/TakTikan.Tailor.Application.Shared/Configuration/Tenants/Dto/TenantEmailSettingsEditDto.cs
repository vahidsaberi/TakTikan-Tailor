using Abp.Auditing;
using TakTikan.Tailor.Configuration.Dto;

namespace TakTikan.Tailor.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}