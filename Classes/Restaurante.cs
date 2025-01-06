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

        public Restaurante() { }

        public Restaurante(int id, string nome, string endereco, string telefone, int capacidade, string descricao, List<Reserva>? reservas = null, List<Mesa>? mesas = null)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Capacidade = capacidade;
            Descricao = descricao;
            Reservas = reservas ?? [];
            Mesas = mesas ?? [];
        }
    }
}
