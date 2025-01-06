using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeRestaurante.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestauranteController : ControllerBase
    {
        private readonly IRestaurante _restauranteServicos;
        private readonly List<Restaurante> _restaurantes = [];

        [HttpGet("{id}")]
        public ActionResult ObtenhaPorId(int id)
        {
            Restaurante restaurante = _restaurantes.FirstOrDefault(x => x.Id == id);
            if (restaurante == null)
            {
                return NotFound($"O restaurante com o id {id} não foi encontrado.");
            }
            return Ok(restaurante);
        }

        [HttpGet]
        public ActionResult ObtenhaTodos()
        {
            Restaurante r1 = new Restaurante(1, "teste", "teste", "1111", 15, "teste");
            _restaurantes.Add(r1);
            if (_restaurantes.Count == 0)
            {
                return NotFound("Não há restaurantes");
            }
            return Ok(_restaurantes);
        }

        [HttpGet("por-nome/{nome}")]
        public ActionResult ObtenhaPorNome(string nome)
        {
            Restaurante restaurante = _restaurantes.FirstOrDefault(m=>m.Nome == nome);

            if(restaurante == null)
            {
                return NotFound($"Restaurante com o nome {nome} não foi encontrado");
            }
            return Ok(restaurante);
        }

        [HttpPost]
        public ActionResult AdicionaRestaurante([FromBody]Restaurante restaurante)
        {
            Restaurante r1 = new Restaurante(1, "teste", "teste", "1111", 15, "teste");
            _restaurantes.Add(r1);
            _restaurantes.Add(restaurante);
            return Ok(restaurante);
        }

        [HttpDelete]
        public ActionResult RemovaRestaurante(int id)
        {
            Restaurante restaurante = _restaurantes.FirstOrDefault(m=>m.Id == id);

            if(restaurante == null)
            {
                return NotFound($"O restaurante {id} não existe");
            }
            _restaurantes.Remove(restaurante);
            return NoContent();
        }
    }
}
