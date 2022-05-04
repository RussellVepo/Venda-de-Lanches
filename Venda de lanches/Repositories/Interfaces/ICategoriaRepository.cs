using Venda_de_lanches.Models;

namespace Venda_de_lanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
