using GestorDeRestaurante.Classes;
using GestorDeRestaurante.Interfaces;

namespace GestorDeRestaurante.Servicos
{
    public class RestauranteServico : IRestaurante
    {
        private static List<Restaurante> _restaurantes = [];

        public void AtualizeRestaurante(int id, Restaurante restaurante)
        {
            var restauranteExistente = _restaurantes.FirstOrDefault(r => r.Id == id);

            restauranteExistente.Nome = restaurante.Nome;
            restauranteExistente.Telefone = restaurante.Telefone;
            restauranteExistente.Descricao = restaurante.Descricao;
            restauranteExistente.Endereco = restaurante.Endereco;

        }

        public void CadastreRestaurante(Restaurante restaurante)
        {
            _restaurantes.Add(restaurante);
        }

        public Restaurante ObtenhaPorId(int id)
        {
            return _restaurantes.FirstOrDefault(i => i.Id == id);
        }

        public List<Restaurante> ObtenhaPorNome(string nome)
        {
            return _restaurantes
                .Where(r => r.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Restaurante> ObtenhaTodos()
        {
            return _restaurantes;
        }

        public void RemovaRestaurante(int id)
        {
           var restauranteParaSerRemovido = _restaurantes.FirstOrDefault(r => r.Id == id);
            _restaurantes.Remove(restauranteParaSerRemovido);
        }
    }
}
