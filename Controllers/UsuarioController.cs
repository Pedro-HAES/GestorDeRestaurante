using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;
using GestorDeRestaurante.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeRestaurante.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuarioServico;
        private readonly List<Usuario> _usuarios = [];

        public UsuarioController(IUsuario usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpPost]
        public ActionResult Cadastre([FromBody] Usuario usuario)
        {
            _usuarios.Add(usuario);
            return Ok(usuario);
        }

        [HttpGet]
        public ActionResult ObtenhaTodosOsUsuarios()
        {
            if(_usuarios.Count == 0)
            {
                return NotFound("Não há usuários.");
            }
            return Ok(_usuarios);
        }

        [HttpGet("por-email/{email}")]
        public ActionResult ObtenhaUsuarioPorEmail(string email)
        {
            Usuario usuario = _usuarios.FirstOrDefault(us => us.Email == email);

            if(usuario == null)
            {
                return NotFound($"O usuário com o email {email} não existe.");
            }
            return Ok(usuario);
        }

        [HttpGet("{id}")]
        public ActionResult ObtenhaPorId(int id)
        {
            Usuario usuario= _usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario == null)
            {
                return NotFound($"O usuário com o ID: {id} não existe.");
            }
            return Ok(usuario);
        }

        [HttpDelete]
        public ActionResult RemoveUsuario(int id)
        {
            Usuario usuarioExistente = _usuarios.FirstOrDefault(r => r.Id == id);

            if (usuarioExistente == null)
            {
                return NotFound($"O usuário {id} não existe");
            }
            _usuarios.Remove(usuarioExistente);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizeUsuario(int id, [FromBody] Usuario usuarioAtualizado)
        {
            Usuario usuarioExistente = _usuarios.FirstOrDefault(u => u.Id == id);

            if (usuarioExistente == null)
            {
                return NotFound($"Usuário com ID {id} não encontrado.");
            }

            usuarioExistente.Nome = usuarioAtualizado.Nome;
            usuarioExistente.Email = usuarioAtualizado.Email;
            usuarioExistente.Telefone = usuarioAtualizado.Telefone;

            return Ok(usuarioExistente);  
        }


    }
}
