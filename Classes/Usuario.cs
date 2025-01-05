using GestorDeRestaurante.Enumeradores;

namespace GestorDeRestaurante.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
        public List<Reserva>? Reservas { get; set; } = [];

        public Usuario() { }

        public Usuario(int id, string nome, string email, string senha, string telefone, EnumTipoDeUsuario tipoDeUsuario, List<Reserva>? reservas = null)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            TipoDeUsuario = tipoDeUsuario;
            Reservas = reservas ?? [];
        }
    }
}