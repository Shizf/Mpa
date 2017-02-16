using System.Linq;
using Mpa.EntityFramework;
using Mpa.MultiTenancy;

namespace Mpa.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MpaDbContext _context;

        public DefaultTenantCreator(MpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
