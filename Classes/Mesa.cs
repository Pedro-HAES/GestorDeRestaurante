namespace GestorDeRestaurante.Classes
{
    public class Mesa
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidade { get; set; }
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }
        public List<Reserva> Reservas { get; set; } = [];

        public Mesa() { }

        public Mesa(int id, int numeroMesa, int capacidade, int restauranteId, Restaurante restaurante, List<Reserva>? reservas = null)
        {
            Id = id;
            NumeroMesa = numeroMesa;
            Capacidade = capacidade;
            RestauranteId = restauranteId;
            Restaurante = restaurante;
            Reservas = reservas ?? [];
        }
    }
}
