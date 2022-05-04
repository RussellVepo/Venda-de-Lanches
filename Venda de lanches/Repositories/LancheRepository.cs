using Microsoft.EntityFrameworkCore;
using Venda_de_lanches.Context;
using Venda_de_lanches.Models;
using Venda_de_lanches.Repositories.Interfaces;

namespace Venda_de_lanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private AppDbContext _context;

        private readonly AppDbContext_context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => throw new NotImplementedException();

        public Lanche GetLancheById(int lancheId)
        {
            throw new NotImplementedException();
        }
    }
}
