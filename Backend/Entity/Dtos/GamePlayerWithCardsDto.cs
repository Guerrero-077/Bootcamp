namespace Entity.Dtos
{
    public class GamePlayerWithCardsDto
    {
        public int GamePlayerId { get; set; }
        public string PlayerName { get; set; } = string.Empty;
        //public PlayerDto Player { get; set; }
        public List<CardDto> Cards { get; set; } = new();
    }

}
