using Entity.Models.Base;

namespace Entity.Models
{
    public class Card : BaseModel
    {
        public int Code { get; set; }
        public int Force { get; set; }
        public int Speed { get; set; }
        public int Popularity { get; set; }
        public int Appearances { get; set; }
        public int IQ { get; set; }

        public Deck? Decks { get; set; }
    }
}
