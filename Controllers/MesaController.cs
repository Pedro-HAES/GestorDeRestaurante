using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeRestaurante.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MesaController : ControllerBase
    {
        private readonly IMesa _mesaServico;
        private readonly List<Mesa> _mesas = [];
        [HttpPost]
        public ActionResult CadastreMesa(Mesa mesa)
        {
            _mesas.Add(mesa);
            return Ok(mesa);
        }
    }
}
