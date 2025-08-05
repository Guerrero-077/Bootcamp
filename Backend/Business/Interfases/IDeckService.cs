using Entity.Dtos;
using Entity.Models;

namespace Business.Interfases
{
    public interface IDeckService : IBaseBusiness<Deck, DeckDto>
    {
        //Task<IEnumerable<DeckDto>> GetDecksAsync();
        Task<IEnumerable<DeckDto>> GetDecksByPlayerAsync(int playerId);

        //Eliminar todos los masos luego de finalizar una partida
        Task<int> DeleteAllDecks();

    }
}
