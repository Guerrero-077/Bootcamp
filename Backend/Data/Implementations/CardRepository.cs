using Data.Interfases;
using Data.Repository;
using Entity.Context;
using Entity.Models;

namespace Data.Implements
{
    public class CardRepository : BaseData<Card>, ICardRepository
    {
        public CardRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
