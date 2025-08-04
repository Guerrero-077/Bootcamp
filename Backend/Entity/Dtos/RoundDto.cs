using Entity.Models.Base;

namespace Entity.Dtos
{
    public class RoundDto : BaseModel
    {
        public int NumberRound { get; set; }
        public string SelectedAttriute { get; set; } = string.Empty;

        public int GameId { get; set; }
    }
}
