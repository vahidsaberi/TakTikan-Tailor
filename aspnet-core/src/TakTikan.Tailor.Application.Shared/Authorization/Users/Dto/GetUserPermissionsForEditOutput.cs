using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Permissions.Dto;

namespace TakTikan.Tailor.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}