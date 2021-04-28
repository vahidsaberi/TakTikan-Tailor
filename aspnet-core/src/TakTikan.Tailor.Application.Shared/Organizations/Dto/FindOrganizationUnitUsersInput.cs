using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
