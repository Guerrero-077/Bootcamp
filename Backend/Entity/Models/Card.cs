using Entity.Models.Base;

namespace Entity.Models
{
    public class Card : BaseModel
    {
        public string Url { get; set; } = string.Empty;
        public int Force { get; set; }
        public int Speed { get; set; }
        public int Popularity { get; set; }
        public int Appearances { get; set; }
        public int Resistance { get; set; }
        public int IQ { get; set; }

        public List<Deck>? Decks { get; set; }
        public List<Move>? Moves { get; set; }
    }

}
