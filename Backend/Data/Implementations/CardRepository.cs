using Data.Interfases;
using Data.Repository;
using Entity.Conetxt;
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
