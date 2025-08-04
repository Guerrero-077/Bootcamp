using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements
{
    public class GamePlayerRepository : BaseData<GamePlayer>, IGamePlayerRepository
    {
        public GamePlayerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<GamePlayer>> GetAll()
        {
            return await _dbSet
                .Include(x => x.Player)
                .ToListAsync();
        }
    }
}
