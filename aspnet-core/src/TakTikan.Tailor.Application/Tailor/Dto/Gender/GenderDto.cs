using Abp.Application.Services.Dto;

namespace TakTikan.Tailor.Dto
{
    public class GenderDto : FullAuditedEntityDto
    {
        public string Title { get; set; }

        public bool IsDisabled { get; set; }
    }
}
