using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class RoomController : GenericController<Room, RoomDto>
    {
        public RoomController(IBaseBusiness<Room, RoomDto> business) : base(business)
        {
        }
    }
}
