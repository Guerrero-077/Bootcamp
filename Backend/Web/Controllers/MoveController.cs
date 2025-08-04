using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class MoveController : GenericController<Move, MoveDto>
    {
        public MoveController(IBaseBusiness<Move, MoveDto> business) : base(business)
        {
        }
    }
}
