using Data.Interfases;
using Data.Repository;
using Entity.Conetxt;
using Entity.Models;

namespace Data.Implements
{
    public class GamePlayerRepository : BaseData<GamePlayer>, IGamePlayerRepository
    {
        public GamePlayerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
