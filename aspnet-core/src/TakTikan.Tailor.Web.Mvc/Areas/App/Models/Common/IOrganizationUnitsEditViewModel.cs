using System.Collections.Generic;
using TakTikan.Tailor.Organizations.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}