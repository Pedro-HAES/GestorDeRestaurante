using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;

namespace GestorDeRestaurante.Servicos
{
    public class MesaServico : IMesa
    {
        private static List<Mesa> _mesas = [];

        public void AtualizeMesa(Mesa mesa)
        {
            throw new NotImplementedException();
        }

        public void CadastreMesa(Mesa mesa)
        {
            _mesas.Add(mesa);
        }

        public Mesa ObtenhaPorId(int id)
        {
            return _mesas.FirstOrDefault(m => m.Id == id);
        }

        public List<Mesa> ObtenhaMesasPorIdRestaurante(int restauranteId)
        {
            throw new NotImplementedException();
        }

        public void RemovaMesa(int id)
        {
            Mesa mesa = _mesas.FirstOrDefault(me => me.Id == id);
            _mesas.Remove(mesa);
        }
    }
}
