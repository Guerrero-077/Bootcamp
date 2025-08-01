using Data.Interfases;
using Data.Repository;
using Entity.Conetxt;
using Entity.Models;

namespace Data.Implements
{
    public class PlayerRepository : BaseData<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
