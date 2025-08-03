using Business.Interfases;
using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class RoomController : GenericController<Room, RoomDto>
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService business) : base(business)
        {
            _roomService = business;
        }

        /// <summary>
        /// Inicia una partida en la sala especificada. Reparte cartas a los jugadores.
        /// </summary>
        [HttpPost("{roomId}/start")]
        public async Task<ActionResult<GameStartResultDto>> StartGame(int roomId)
        {
            try
            {
                var result = await _roomService.StartGameAsync(roomId);

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
