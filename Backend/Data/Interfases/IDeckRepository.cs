using Entity.Models;

namespace Data.Interfases
{
    public interface IDeckRepository : IBaseData<Deck>
    {
        //Task<IEnumerable<Deck>> GetDeckWithUserCard();
        Task<IEnumerable<Deck>> GetDecksByPlayerIdAsync(int playerId);
        Task<List<Deck>> GetDecksBygameWithCardAndPlayer(int gameId);
        Task AddRangeAsync(IEnumerable<Deck> decks);
    }
}
