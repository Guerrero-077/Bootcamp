using Data.Interfases;
using Data.Repository;
using Entity.Conetxt;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements
{
    public class RoomRepository : BaseData<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Room?> GetWithPlayersAsync(int roomId) =>
            await _context.Set<Room>()
                .Include(r => r.GamePlayers)
                    .ThenInclude(gp => gp.Player)
                .FirstOrDefaultAsync(r => r.Id == roomId);
    }
}
