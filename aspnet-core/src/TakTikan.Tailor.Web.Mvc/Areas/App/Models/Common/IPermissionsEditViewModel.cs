using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Permissions.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}