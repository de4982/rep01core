using Abp.Authorization;
using CoreCMS.Authorization.Roles;
using CoreCMS.Authorization.Users;

namespace CoreCMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
