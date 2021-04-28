using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.Authorization.Permissions.Dto;
using TakTikan.Tailor.Web.Areas.App.Models.Common;

namespace TakTikan.Tailor.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}