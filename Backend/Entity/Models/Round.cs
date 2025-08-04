using Entity.Models.Base;

namespace Entity.Models
{
    public class Round : BaseModel
    {
        public int NumberRound { get; set; }
        public string SelectedAttriute { get; set; } = string.Empty;

        public int GameId { get; set; }
        public Game? Game { get; set; }

        public List<Move> Moves { get; set; } = [];
    }
}
