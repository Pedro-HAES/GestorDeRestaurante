using GestorDeRestaurante.Classes;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeRestaurante.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly List<Reserva> _reservas = new List<Reserva>();

        [HttpPost]
        public IActionResult CadastrarReserva(int usuarioId, [FromBody] Reserva reserva)
        {
            reserva.UsuarioId = usuarioId;
            _reservas.Add(reserva);

            return Ok(reserva);
        }

    }
}
