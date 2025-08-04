using Entity.Models.Base;

namespace Entity.Models
{
    public class GamePlayer : BaseModel
    {
        public int GameId { get; set; }
        public Game? Game { get; set; }
        public int PlayerId { get; set; } 
        public Player? Player { get; set; }

        public int Score { get; set; }

        public List<Deck> Decks { get; set; } = new List<Deck>();
        public List<Move> Moves { get; set; } = new List<Move>();
    }


}
