using Entity.Models.Base;

namespace Entity.Models
{
    public class Deck : BaseModel
    {
        public int GamePlayerId { get; set; }
        public GamePlayer? GamePlayer { get; set; }

        public int CardId { get; set; }
        public Card? Card { get; set; }
        public bool Use {  get; set; }

        //public bool Active { get; set; }
        //public List<Card>? Card { get; set; }
    }
}
