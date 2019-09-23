using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using WM.Common.Interfaces;

namespace Cad.DataAccessLayer.Repositories
{
    public class GenericDataRepository<TEntity> : IGenericDataRepository<TEntity> where TEntity : class
    {
        internal DbContext context;
        internal DbSet<TEntity> dbSet;

        public GenericDataRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsQueryable();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, params string[] navigationProperties)
        {
            var query = context.Set<TEntity>().AsQueryable();

            foreach (string navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }

            return query.Where(predicate);
        }

        public virtual TEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            var query = context.Set<TEntity>().AsQueryable();

            return query.FirstOrDefault(predicate);
        }

        public virtual void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(params object[] keys)
        {
            var entity = context.Set<TEntity>().Find(keys);
            if (entity != null)
            {
                Delete(entity);
            }
        }

        public virtual void Delete(object id)
        {
            var entity = context.Set<TEntity>().Find(id);

            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }
       
        public virtual void Update(TEntity entityToUpdate)
        {
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
