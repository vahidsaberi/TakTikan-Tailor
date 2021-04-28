using Abp.Authorization;
using TakTikan.Tailor.Authorization.Roles;
using TakTikan.Tailor.Authorization.Users;

namespace TakTikan.Tailor.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
