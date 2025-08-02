using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class PlayerController : GenericController<Player, PlayerDto>
    {
        public PlayerController(IBaseBusiness<Player, PlayerDto> business) : base(business)
        {
        }
    }
}
