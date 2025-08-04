using Entity.Models.Base;

namespace Entity.Dtos
{
    public class PlayerDto : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; }
    }
}
