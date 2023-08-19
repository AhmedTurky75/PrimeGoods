using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;


namespace Store.DataAccess.Repositories
{
    public interface IRepository<T> where T : class
    {
        #region GET
        IQueryable<T> GetAll(Expression<Func<T,bool>> where);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T,bool>> where);
        T GetFirst(Expression <Func<T,bool>> where);
        Task<T> GetFirstAsync(Expression<Func<T,bool>> where);
        T GetLast(Expression<Func<T,bool>> where);
        Task<T> GetLastAsync(Expression<Func<T,bool>> where);
        #endregion

        #region ADD
        T Add(T entity);
        Task AddAsync(T entity);
        void AddRange(IEnumerable<T> entities);
        Task AddRangeAsync(IEnumerable<T> entities);
        #endregion

        #region UPDATE
        EntityEntry<T> Update(T entity);
        #endregion

        #region REMOVE
        EntityEntry<T> Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        #endregion

        #region AGGREGATE
        #region COUNT
        int Count();
        Task<int> CountAsync();
        #endregion

        #region MIN
        //Compares accourding to the primary key of the specified entity
        T GetMinimum();
        //Compares accourding to the primary key of the specified entity
        Task<T> GetMinimumAsync();
        object GetMinimum(Expression<Func<T,object>> selector);
        Task<object> GetMinimumAsync(Expression<Func<T,object>> selector);
        #endregion

        #region MAX
        //Compares accourding to the primary key of the specified entity
        T GetMaximum();
        //Compares accourding to the primary key of the specified entity
        Task<T> GetMaximumAsync();
        object GetMaximum(Expression<Func<T,object>> selector);
        Task<object> GetMaximumAsync(Expression<Func<T,object>> selector);
        #endregion
        #endregion

        #region EXISTS
        bool IsExits(Expression<Func<T,bool>> where);
        Task<bool> IsExitsAsync(Expression<Func<T,bool>> where);
        #endregion

        #region SAVE
        void Save(); 
        #endregion
    }
}
