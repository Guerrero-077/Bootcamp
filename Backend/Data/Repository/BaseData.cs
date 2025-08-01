using Data.Interfases;
using Entity.Conetxt;
using Entity.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class BaseData<T> : IBaseData<T> where T : BaseModel
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseData(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }
        public async Task<IEnumerable<T>> GetAll()
        {
             return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<T> Save(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T?> Update(T entity)
        {
            var entityUpdated = await _dbSet.FindAsync(entity.Id);
            if (entityUpdated == null) return null;
            _context.Entry(entityUpdated).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<int?> Delete(int id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null) return null;
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync();
        }


    }
}
