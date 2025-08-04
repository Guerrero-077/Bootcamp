

using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class DeckController : GenericController<Deck, DeckDto>
    {
        private readonly IDeckService _deckService;
        public DeckController(IDeckService business) : base(business)
        {
            _deckService = business;
        }

        //[HttpGet("GetAllWhitCardPlayer")]
        //public async Task<IActionResult> GetDecksWithCardAndPlayerAsync()
        //{
        //    var result = await _deckService.GetDecksAsync();
        //    return Ok(result);
        //}

        [HttpGet("player/{playerId}")]
        public async Task<IActionResult> GetDecksByPlayer(int playerId)
        {
            var result = await _deckService.GetDecksByPlayerAsync(playerId);
            return Ok(result);
        }

        //[HttpGet("room/{roomId}")]
        //public async Task<ActionResult<List<DeckDto>>> GetDecksByRoom(int roomId)
        //{
        //    try
        //    {
        //        var decks = await _deckService.GetDecksByRoomWithCardAndPlayer(roomId);

        //        if (decks == null || !decks.Any())
        //            return NotFound($"No se encontraron decks para la sala {roomId}");

        //        var result = decks.Adapt<List<DeckDto>>();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Loguear el error si tienes logger
        //        return StatusCode(500, $"Error al obtener decks: {ex.Message}");
        //    }
        //}
    }
}
