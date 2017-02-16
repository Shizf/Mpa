using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Mpa.EntityFramework.Repositories
{
    public abstract class MpaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MpaRepositoryBase(IDbContextProvider<MpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MpaRepositoryBase<TEntity> : MpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MpaRepositoryBase(IDbContextProvider<MpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
