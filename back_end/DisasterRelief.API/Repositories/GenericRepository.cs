using DisasterReliefAPI.Data;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DisasterReliefAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        protected readonly AppDbContext _context;

        protected readonly DbSet<T> _dbSet;


        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }


        public virtual async Task<T?> GetByIdAsync(
            params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }


        public virtual async Task<IEnumerable<T>> FindAsync(
            Expression<Func<T, bool>> predicate)
        {
            return await _dbSet
                .Where(predicate)
                .ToListAsync();
        }


        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }


        public virtual async Task AddRangeAsync(
            IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }


        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);
        }


        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }


        public virtual void DeleteRange(
            IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }


        public virtual async Task<bool> ExistsAsync(
            params object[] keyValues)
        {
            var entity = await _dbSet.FindAsync(keyValues);

            return entity != null;
        }


        public virtual async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}