using Venda_de_lanches.Context;
using Venda_de_lanches.Models;
using Venda_de_lanches.Repositories.Interfaces;

namespace Venda_de_lanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
