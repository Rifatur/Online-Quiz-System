using Microsoft.EntityFrameworkCore;
using QuizAppDataAccess.Context;
using QuizAppDataAccess.Services.Interface;
using System.Linq.Expressions;

namespace QuizAppDataAccess.Services.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entity = await _entities.FindAsync(id);
            if (entity == null) return null;
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
