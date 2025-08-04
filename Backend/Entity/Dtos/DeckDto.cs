using Entity.Models.Base;

namespace Entity.Dtos
{
    public class DeckDto : BaseModel
    {
        public int GamePlayerId { get; set; }
        public string PlayerName { get; set; }

        public CardDto Card { get; set;  }
        public bool Used { get; set; }

        //public int CardId { get; set; }
        //public string Url { get; set; } = string.Empty;
        //public PlayerDto? Player { get; set; }
    }
}
