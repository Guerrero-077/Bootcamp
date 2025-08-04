using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class GameController : GenericController<Game, GameDto>
    {
        private readonly IGameService _roomService;
        public GameController(IGameService business) : base(business)
        {
            _roomService = business;
        }

        /// <summary>
        /// Inicia una partida en la sala especificada. Reparte cartas a los jugadores.
        /// </summary>
        [HttpPost("{gameId}/start")]
        public async Task<ActionResult<GameStartResultDto>> StartGame(int gameId)
        {
            try
            {
                var result = await _roomService.StartGameAsync(gameId);

                if (!result.Success)
                    return BadRequest("No se pudo iniciar la partida.");

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log de error, si aplica
                return StatusCode(500, $"Error al iniciar la partida: {ex.Message}");
            }
        }
    }
}
