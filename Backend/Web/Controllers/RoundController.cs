using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class RoundController : GenericController<Round, RoundDto>
    {
        public RoundController(IBaseBusiness<Round, RoundDto> business) : base(business)
        {
        }
    }
}
