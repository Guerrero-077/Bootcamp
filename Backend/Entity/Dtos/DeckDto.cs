using Entity.Models.Base;

namespace Entity.Dtos
{
    public class DeckDto : BaseModel
    {
        public int GamePlayerId { get; set; }

        public int CardId { get; set; }
        public bool User { get; set; }

        //public PlayerDto? Player { get; set; }
    }
}
