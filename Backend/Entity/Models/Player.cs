using Entity.Models.Base;

namespace Entity.Models
{
    public class Player : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; } = true;

        public List<GamePlayer>? GamePlayers { get; set; }
    }
}
