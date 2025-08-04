using Entity.Models.Base;

namespace Entity.Models
{
    public class Game : BaseModel
    {
        public DateTime CreateAt { get; set; } = DateTime.Now;  

        public List<GamePlayer>? GamePlayers { get; set; }
        public List<Round> Rounds { get; set; } = [];

    }
}
