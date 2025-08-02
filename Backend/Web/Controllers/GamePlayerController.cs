using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class GamePlayerController : GenericController<GamePlayer, GamePlayerDto>
    {
        public GamePlayerController(IBaseBusiness<GamePlayer, GamePlayerDto> business) : base(business)
        {
        }
    }
}
