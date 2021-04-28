using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Permissions.Dto;

namespace TakTikan.Tailor.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}