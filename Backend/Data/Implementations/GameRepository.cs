using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements
{
    public class GameRepository : BaseData<Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Game?> GetWithPlayersAsync(int roomId) =>
            await _context.Set<Game>()
                .Include(r => r.GamePlayers)
                    .ThenInclude(gp => gp.Player)
                .FirstOrDefaultAsync(r => r.Id == roomId);
    }
}
