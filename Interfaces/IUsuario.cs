using GestorDeRestaurante.Classes;

namespace GestorDeRestaurante.Interfaces
{
    public interface IUsuario
    {
        Usuario ObtenhaPorId(int id);
        Usuario ObtenhaPorEmail(string email);
        void CadastreUsuario(Usuario usuario);
        bool VerifiqueUsuario(string email, string senha);
        void AtualizeUsuario(Usuario usuario);
        void RemovaUsuario(int id);
    }
}
