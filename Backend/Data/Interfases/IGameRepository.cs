using Entity.Models;

namespace Data.Interfases
{
    public interface IGameRepository : IBaseData<Game>
    {
        Task<Game?> GetWithPlayersAsync(int roomId);
    }
}
