namespace Entity.Dtos
{
    public class GameStartResultDto
    {
        public bool Success { get; set; }
        public int RoomId { get; set; }
        public List<GamePlayerWithCardsDto> Players { get; set; } = new();
    }

}
