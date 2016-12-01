using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Web.CoreApp.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entityCollection);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entityCollection);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entity);



    }
}
