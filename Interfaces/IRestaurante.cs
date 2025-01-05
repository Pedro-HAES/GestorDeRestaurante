using GestorDeRestaurante.Classes;

namespace GestorDeRestaurante.Interfaces
{
    public interface IRestaurante
    {
        Restaurante ObtenhaPorId(int id);
        List<Restaurante> ObtenhaTodos();
        void CadastreRestaurante(Restaurante restaurante);
        void AtualizeRestaurante(Restaurante restaurante);
        void RemovaRestaurante(int id);
        List<Restaurante> ObtenhaPorNome(string nome);

    }
}
