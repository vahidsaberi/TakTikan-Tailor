using System.Linq;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using TakTikan.Tailor.Editions;
using TakTikan.Tailor.EntityFrameworkCore;

namespace TakTikan.Tailor.Migrations.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly TailorDbContext _context;

        public DefaultTenantBuilder(TailorDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == MultiTenancy.Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new MultiTenancy.Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
