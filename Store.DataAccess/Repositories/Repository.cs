using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Store.DataAccess.DataContext;
using System.Linq.Expressions;

namespace Store.DataAccess.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        #region FIELDS
        protected readonly StoreContext _dbContext;
        internal DbSet<T> dbSet;
        #endregion

        #region CTOR
        public Repository(StoreContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<T>();
        }
        #endregion


        #region GET
        public virtual IQueryable<T> GetAll(Expression<Func<T,bool>> where)
        {
            return dbSet.AsNoTracking().Where(where).AsQueryable();
        }

        public virtual async Task<IQueryable<T>> GetAllAsync(Expression<Func<T,bool>> where)
        {
            var list = await _dbContext.Set<T>().AsNoTracking().Where(where).ToListAsync();
            return list.AsQueryable();
        }

        public virtual T GetFirst(Expression<Func<T,bool>> where)
        {
            return dbSet.AsNoTracking().FirstOrDefault(where); 
        }

        public virtual async Task<T> GetFirstAsync(Expression<Func<T,bool>> where)
        {
            return await dbSet.AsNoTracking().FirstOrDefaultAsync(where);
        }

        public virtual T GetLast(Expression<Func<T,bool>> where)
        {
            return dbSet.AsNoTracking().LastOrDefault(where);
        }

        public virtual async Task<T> GetLastAsync(Expression<Func<T,bool>> where)
        {
            return await dbSet.AsNoTracking().LastOrDefaultAsync(where);
        }
        #endregion

        #region ADD
        public virtual T Add(T entity)
        {
            return dbSet.Add(entity).Entity;
        }

        public virtual async Task AddAsync(T entity)
        {
             await dbSet.AddAsync(entity);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
           await dbSet.AddRangeAsync(entities);
        }
        #endregion

        #region UPDATE
        public virtual EntityEntry<T> Update(T entity)
        {
            foreach(var entry in _dbContext.ChangeTracker.Entries<T>().ToList())
            {
                entry.State = EntityState.Detached; 
            }
            return dbSet.Update(entity);
        }
        #endregion

        #region REMOVE
        public virtual EntityEntry<T> Remove(T entity)
        {
            return dbSet.Update(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);    
        }
        #endregion

        #region AGGREGATE
        #region COUNT
        public virtual int Count()
        {
            return dbSet.Count();
        }

        public virtual async Task<int> CountAsync()
        {
            return await dbSet.CountAsync();
        }

        #endregion

        #region MIN
        public virtual T GetMinimum()
        {
            return dbSet.Min(); 
        }

        public virtual object GetMinimum(Expression<Func<T,object>> selector)
        {
            return dbSet.Min(selector);
        }

        public virtual async Task<T> GetMinimumAsync()
        {
            return await dbSet.MinAsync();
        }

        public virtual async Task<object> GetMinimumAsync(Expression<Func<T,object>> selector)
        {
            return await dbSet.MinAsync(selector);
        }
        #endregion

        #region MAX
        public virtual T GetMaximum()
        {
            return dbSet.Max(); 
        }

        public virtual object GetMaximum(Expression<Func<T,object>> selector)
        {
            return dbSet.Max(selector);
        }

        public virtual async Task<T> GetMaximumAsync()
        {
            return await dbSet.MaxAsync();
        }

        public virtual async Task<object> GetMaximumAsync(Expression<Func<T,object>> selector)
        {
            return await dbSet.MaxAsync(selector);
        }
        #endregion
        #endregion

        #region EXISTS
        public virtual bool IsExits(Expression<Func<T,bool>> where)
        {
            return dbSet.Find(where) != null ? true : false;
        }

        public virtual async Task<bool> IsExitsAsync(Expression<Func<T,bool>> where)
        {
            return await dbSet.FindAsync(where) != null ? true : false;
        }

        #endregion

        #region SAVE
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
