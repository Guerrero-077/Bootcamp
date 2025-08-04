using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements
{
    public class DeckRepositoriy : BaseData<Deck>, IDeckRepository
    {
        public DeckRepositoriy(ApplicationDbContext context) : base(context)
        {
        }

        //public async Task<IEnumerable<Deck>> GetDeckWithUserCard()
        //{
        //    return await _dbSet
        //        .Include(d => d.GamePlayer)
        //            .ThenInclude(gp => gp.Player)
        //        .Include(d => d.Card)
        //        .ToListAsync();
        //}

        //public async Task<IEnumerable<Deck>> GetDecksByPlayerIdAsync(int playerId)
        //{
        //    return await _context.Set<Deck>()
        //        .Include(d => d.Card)
        //        .Include(d => d.GamePlayer)
        //            .ThenInclude(gp => gp.Player)
        //        .Where(d => d.GamePlayer.PlayerId == playerId)
        //        .ToListAsync();
        //}

        public async Task AddRangeAsync(IEnumerable<Deck> decks)
        {
            await _context.Decks.AddRangeAsync(decks);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Deck>> GetDecksBygameWithCardAndPlayer(int gameId)
        {
            return await _context.Decks
                .Include(d => d.Card)
                .Include(d => d.GamePlayer)
                    .ThenInclude(gp => gp.Player)
                .Where(d => d.GamePlayer.GameId == gameId)
                .ToListAsync();
        }



    }
}
