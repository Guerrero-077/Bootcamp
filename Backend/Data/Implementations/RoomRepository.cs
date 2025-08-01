using Data.Interfases;
using Data.Repository;
using Entity.Conetxt;
using Entity.Models;

namespace Data.Implements
{
    public class RoomRepository : BaseData<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
