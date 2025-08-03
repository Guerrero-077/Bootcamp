using Entity.Dtos;
using Entity.Models;

namespace Business.Interfases
{
    public interface IRoomService : IBaseBusiness<Room, RoomDto>
    {
        //Task<RoomDto?> GetRoomWithPlayersAsync(int roomId);
        Task<GameStartResultDto> StartGameAsync(int roomId);
    }
}
