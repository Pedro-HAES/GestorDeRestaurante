namespace GestorDeRestaurante.Classes
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Capacidade { get; set; }
        public string Descricao { get; set; }
        public List<Reserva> Reservas { get; set; } = [];
        public List<Mesa> Mesas { get; set; } = [];

    }
}
