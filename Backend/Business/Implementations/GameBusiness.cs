using Business.Implementations.Base;
using Business.Interfases;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;
using Mapster;

namespace Business.Implementations
{
    public class GameBusiness : BaseBusiness<Game, GameDto>, IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly ICardRepository _cardRepository;
        private readonly IDeckRepository _deckRepository;
        public GameBusiness(IGameRepository data, ICardRepository cardRepository, IDeckRepository deckRepository) : base(data)
        {
            _gameRepository = data;
            _cardRepository = cardRepository;
            _deckRepository = deckRepository;
        }






        public async Task<GameStartResultDto> StartGameAsync(int gameId)
        {
            var game = await _gameRepository.GetWithPlayersAsync(gameId);

            Validategame(game);

            var allCards = await _cardRepository.GetAll();
            var shuffled = allCards.OrderBy(_ => Guid.NewGuid()).ToList();

            ValidateCardAvailability(game.GamePlayers.Count, shuffled.Count);

            foreach (var player in game.GamePlayers)
            {
                var playerCards = GetPlayerDeck(shuffled, player.Id);
                await _deckRepository.AddRangeAsync(playerCards);
            }

            await _gameRepository.Update(game);


            var fullDecks = await _deckRepository.GetDecksBygameWithCardAndPlayer(gameId);

            // Agrupar por GamePlayer y mapear
            var grouped = fullDecks
                .GroupBy(d => d.GamePlayerId)
                .Select(group =>
                {
                    var first = group.First();
                    return new GamePlayerWithCardsDto
                    {
                        GamePlayerId = first.GamePlayerId,
                        PlayerName = first.GamePlayer!.Player!.Name,
                        Cards = group.Select(d => d.Card!.Adapt<CardDto>()).ToList()
                    };
                }).ToList();

            return new GameStartResultDto
            {
                Success = true,
                GameId = gameId,
                Players = grouped
            };
        }






        private void Validategame(Game game)
        {
            if (game == null)
                throw new Exception("La sala no existe.");

            int count = game.GamePlayers.Count;
            if (count < 2 || count > 7)
                throw new Exception("Número inválido de jugadores");
        }

        private void ValidateCardAvailability(int playerCount, int totalCards)
        {
            if (totalCards < playerCount * 8)
                throw new Exception("No hay suficientes cartas disponibles.");
        }

        private List<Deck> GetPlayerDeck(List<Card> shuffledCards, int gamePlayerId)
        {
            var deck = new List<Deck>();
            for (int i = 0; i < 8; i++)
            {
                var card = shuffledCards[0];
                shuffledCards.RemoveAt(0);

                deck.Add(new Deck
                {
                    GamePlayerId = gamePlayerId,
                    CardId = card.Id
                });
            }

            return deck;
        }



    }
}
