using Entity.Models.Base;

namespace Entity.Models
{
    public class Card : BaseModel
    {
        public string Url { get; set; }
        public int Force { get; set; }
        public int Speed { get; set; }
        public int Popularity { get; set; }
        public int Appearances { get; set; }
        public int Resistance { get; set; }
        public int IQ { get; set; }

        public int? DeckId { get; set; }

        public Deck? Decks { get; set; }
    }
}
