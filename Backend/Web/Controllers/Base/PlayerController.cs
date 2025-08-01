using Business.Interfases;
using Entity.Dtos;
using Entity.Models;

namespace Web.Controllers.Base
{
    public class PlayerController : GenericController<Player, PlayerDto>
    {
        public PlayerController(IBaseBusiness<Player, PlayerDto> business) : base(business)
        {
        }
    }
}
