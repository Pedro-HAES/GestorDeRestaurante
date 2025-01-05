using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;

namespace GestorDeRestaurante.Servicos
{
    public class UsuarioServico : IUsuario
    {
        private static List<Usuario> _usuarios = [];
        public void AtualizeUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void CadastreUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
        public Usuario ObtenhaPorEmail(string email)
        {
            return _usuarios.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public Usuario ObtenhaPorId(int id)
        {
            return _usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void RemovaUsuario(int id)
        {
            var usuarioASerRemovido = _usuarios.FirstOrDefault(r => r.Id == id);
            _usuarios.Remove(usuarioASerRemovido);
        }

        public bool VerifiqueUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
