using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CoreApp.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity Add(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        ICollection<TEntity> GetAll();
    }
}
