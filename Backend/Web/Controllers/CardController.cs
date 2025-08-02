using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class CardController : GenericController<Card, CardDto>
    {
        public CardController(IBaseBusiness<Card, CardDto> business) : base(business)
        {
        }
    }
}
