using Entity.Dtos;
using Entity.Models;

namespace Business.Interfases
{
    public interface IGameService : IBaseBusiness<Game, GameDto>
    {
        //Task<RoomDto?> GetRoomWithPlayersAsync(int roomId);
        Task<GameStartResultDto> StartGameAsync(int gameId);
    }
}
