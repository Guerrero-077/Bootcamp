using Data.Interfases;
using Data.Repository;
using Entity.Conetxt;
using Entity.Models;

namespace Data.Implements
{
    public class DeckRepositoriy : BaseData<Deck>, IDeckRepository
    {
        public DeckRepositoriy(ApplicationDbContext context) : base(context)
        {
        }
    }
}
