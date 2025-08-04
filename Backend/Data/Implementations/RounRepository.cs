using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;

namespace Data.Implementations
{
    public class RounRepository : BaseData<Round>, IRounRepository
    {
        public RounRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
