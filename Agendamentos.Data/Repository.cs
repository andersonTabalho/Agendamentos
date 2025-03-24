using Microsoft.EntityFrameworkCore;
using Stratega.Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace Stratega.Data.Repositories
{
    public abstract class Repository<TContext, TEntity>(TContext context) : IRepository<TEntity> where TContext : DbContext
                                                                                                 where TEntity : class
    {
        protected readonly TContext _context = context;

        public virtual List<TEntity> GetAll()
            => _context.Set<TEntity>().AsNoTracking().ToList();
        public virtual TEntity? Get(int id)
            => _context.Set<TEntity>().Find(id);
        public virtual async Task<TEntity?> GetAsync(int id)
            => await _context.Set<TEntity>().FindAsync(id);
        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
            => _context.Set<TEntity>().Where(predicate).AsQueryable();

        public virtual void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual void InsertRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        public virtual async Task InsertRangeAsync(List<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public virtual void UpdateRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            _context.SaveChanges();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateRangeAsync(List<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        public virtual void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual void DeleteRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            _context.SaveChanges();
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteRangeAsync(List<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }
    }
}