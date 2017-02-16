using Abp.Authorization;
using Mpa.Authorization.Roles;
using Mpa.MultiTenancy;
using Mpa.Users;

namespace Mpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
