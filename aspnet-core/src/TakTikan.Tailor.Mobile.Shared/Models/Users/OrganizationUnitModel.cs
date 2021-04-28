using Abp.AutoMapper;
using TakTikan.Tailor.Organizations.Dto;

namespace TakTikan.Tailor.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}