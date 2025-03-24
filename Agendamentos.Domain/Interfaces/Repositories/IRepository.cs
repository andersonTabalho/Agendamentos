using System.Linq.Expressions;

namespace Stratega.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        T? Get(int id);
        List<T> GetAll();
        void Delete(T entity);
        void Insert(T entity);
        void Update(T entity);
        Task<T?> GetAsync(int id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        void InsertRange(List<T> entities);
        void UpdateRange(List<T> entities);
        void DeleteRange(List<T> entities);
        Task InsertRangeAsync(List<T> entities);
        Task UpdateRangeAsync(List<T> entities);
        Task DeleteRangeAsync(List<T> entities);
        IQueryable<T?> Find(Expression<Func<T, bool>> predicate);
    }
}
