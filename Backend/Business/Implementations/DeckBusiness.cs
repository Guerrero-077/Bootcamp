using Business.Implementations.Base;
using Business.Interfases;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;
using Mapster;

namespace Business.Implementations
{
    public class DeckBusiness : BaseBusiness<Deck, DeckDto>, IDeckService
    {

        private readonly IDeckRepository _deckRepository;
        public DeckBusiness(IDeckRepository data) : base(data)
        {
            _deckRepository = data;
        }

        //public async Task<IEnumerable<DeckDto>> GetDecksAsync()
        //{
        //    var decks = await _deckRepository.GetDeckWithUserCard();

        //    return decks.Adapt<IEnumerable<DeckDto>>();
        //}

        public async Task<IEnumerable<DeckDto>> GetDecksByPlayerAsync(int playerId)
        {
            var decks = await _deckRepository.GetDecksByPlayerIdAsync(playerId);
            return decks.Adapt<IEnumerable<DeckDto>>();
        }

        public async Task<int> DeleteAllDecks()
        {
            var rowsAffected = await _deckRepository.DeleteAllDecks();
            return rowsAffected;
        }

    }
}
