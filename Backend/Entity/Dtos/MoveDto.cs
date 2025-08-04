using Entity.Models.Base;

namespace Entity.Dtos
{
    public class MoveDto : BaseModel
    {
        public int UsedValue { get; set; }
        public bool winner { get; set; }
        public int RounId { get; set; }
        public int CardId { get; set; }
        public int GamePlayerId { get; set; }
    }
}
