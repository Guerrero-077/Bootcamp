using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;

namespace Data.Implements
{
    public class PlayerRepository : BaseData<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Player> Save(Player entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            var relation = new GamePlayer
            {
                GameId = 1,
                PlayerId = entity.Id
            };
            _context.Add(relation);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
