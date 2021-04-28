using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}