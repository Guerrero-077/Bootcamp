using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;

namespace Data.Implementations
{
    public class MoveRepository : BaseData<Move> , IMoveRepository
    {
        public MoveRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
