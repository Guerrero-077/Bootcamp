using Entity.Models.Base;

namespace Entity.Models
{
    public class Move : BaseModel
    {
        public int UsedValue { get; set; }
        public bool winner { get; set; }

        public int RoundId { get; set; }
        public Round? Round { get; set; }
        public int CardId { get; set; }
        public Card? Card { get; set; }
        public int GamePlayerId { get; set; }
        public GamePlayer? GamePlayer { get; set; }
    }
}
