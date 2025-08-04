using Entity.Models.Base;

namespace Entity.Dtos
{
    public class GamePlayerDto : BaseModel
    {
        //public int PlayerId { get; set; }
        //public string PlayerName { get; set; }

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }    
        //public PlayerDto? Player { get; set; }

        public int GameId { get; set; }
        public int Winner { get; set; }
    }
}
