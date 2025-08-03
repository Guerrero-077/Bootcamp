using Entity.Models;

namespace Data.Interfases
{
    public interface IDeckRepository : IBaseData<Deck>
    {
        Task<IEnumerable<Deck>> GetDeckWithUserCard();
        Task<IEnumerable<Deck>> GetDecksByPlayerIdAsync(int playerId);
        Task<List<Deck>> GetDecksByRoomWithCardAndPlayer(int roomId);
        Task AddRangeAsync(IEnumerable<Deck> decks);
    }
}
