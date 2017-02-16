using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Mpa.EntityFramework;

namespace Mpa.Migrator
{
    [DependsOn(typeof(MpaDataModule))]
    public class MpaMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MpaDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}