using Entity.Models;

namespace Data.Interfases
{
    public interface IRoomRepository : IBaseData<Room>
    {
        Task<Room?> GetWithPlayersAsync(int roomId);
    }
}
