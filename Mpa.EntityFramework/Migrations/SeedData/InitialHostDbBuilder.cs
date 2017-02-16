using Mpa.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Mpa.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MpaDbContext _context;

        public InitialHostDbBuilder(MpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
