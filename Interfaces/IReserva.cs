using GestorDeRestaurante.Classes;

namespace GestorDeRestaurante.Interfaces
{
    public interface IReserva
    {
        Reserva ObtenhaPorId(int id);
        List<Reserva> ObtenhaPorUsuarioId(int usuarioId);
        List<Reserva> ObtnhaPorRestauranteId(int restauranteId);
        void CadastreReserva(Reserva reserva);
        void AtualizeReserva(Reserva reserva);
        void CanceleReserva(int id);
        bool VerifiqueDisponibilidadeMesa(int mesaId, DateTime dataHora, int duracao);
    }
}
