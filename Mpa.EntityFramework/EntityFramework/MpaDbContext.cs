using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Mpa.Authorization.Roles;
using Mpa.MultiTenancy;
using Mpa.Tasks;
using Mpa.Users;

namespace Mpa.EntityFramework
{
    public class MpaDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<Person> Persons { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MpaDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MpaDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MpaDbContext since ABP automatically handles it.
         */
        public MpaDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MpaDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
