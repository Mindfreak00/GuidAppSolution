using GuideApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GuideApp.Infrasructure
{
    public class RepositoryBase<T> where T : class
    {
        #region Properties
        private GuideAppContext dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory { get; }

        protected GuideAppContext DbContext => dataContext ?? (dataContext = DbFactory.Init());
        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T Get(Guid id) => dbSet.Find(id);

        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeExpressions) => includeExpressions.Aggregate<Expression<Func<T, object>>, IQueryable<T>>
             (dbSet, (current, expression) => current.Include(expression)).ToList();

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where) => dbSet.Where(where).ToList();

        public T Get(Expression<Func<T, bool>> where) => dbSet.Where(where).FirstOrDefault();
        #endregion
    }
}
