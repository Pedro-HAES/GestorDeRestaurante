namespace GestorDeRestaurante.Classes
{
    public class Mesa
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidade { get; set; }
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }

    }
}
