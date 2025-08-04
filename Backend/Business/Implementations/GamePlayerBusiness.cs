using Business.Implementations.Base;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;

namespace Business.Implementations
{
    public class GamePlayerBusiness : BaseBusiness<GamePlayer, GamePlayerDto>
    {
        public GamePlayerBusiness(IBaseData<GamePlayer> data) : base(data)
        {
        }
    }
}
