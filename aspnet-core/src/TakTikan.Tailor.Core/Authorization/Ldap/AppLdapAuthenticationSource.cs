using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using TakTikan.Tailor.Authorization.Users;
using TakTikan.Tailor.MultiTenancy;

namespace TakTikan.Tailor.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}