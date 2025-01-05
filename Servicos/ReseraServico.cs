using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;

namespace GestorDeRestaurante.Servicos
{
    public class ReseraServico : IReserva
    {
        private static List<Reserva> _reservas = [];
        public void AtualizeReserva(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void CadastreReserva(Reserva reserva)
        {
            _reservas.Add(reserva);
        }

        public void CanceleReserva(int id)
        {
            throw new NotImplementedException();
        }

        public Reserva ObtenhaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ObtenhaPorUsuarioId(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ObtnhaPorRestauranteId(int restauranteId)
        {
            throw new NotImplementedException();
        }

        public bool VerifiqueDisponibilidadeMesa(int mesaId, DateTime dataHora, int duracao)
        {
            throw new NotImplementedException();
        }
    }
}
