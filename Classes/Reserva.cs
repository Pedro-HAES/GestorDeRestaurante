using GestorDeRestaurante.Enumeradores;

namespace GestorDeRestaurante.Classes
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int NumeroPessoas { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }
        public EnumStatusDaReserva Status {  get; set; } 
        public int DuracaoEmMinutos { get; set; }
    }
}
