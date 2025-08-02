using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class DeckController : GenericController<Deck, DeckDto>
    {
        public DeckController(IBaseBusiness<Deck, DeckDto> business) : base(business)
        {
        }
    }
}
