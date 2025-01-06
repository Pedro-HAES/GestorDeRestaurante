using GestorDeRestaurante.Classes;

namespace GestorDeRestaurante.Interfaces
{
    public interface IMesa
    {
        Mesa ObtenhaPorId(int id);
        List<Mesa> ObtenhaMesasPorIdRestaurante(int restauranteId);
        void CadastreMesa(Mesa mesa);
        void AtualizeMesa(Mesa mesa);
        void RemovaMesa(int id);
    }
}
