using Microsoft.EntityFrameworkCore;
using Venda_de_lanches.Models;

namespace Venda_de_lanches.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche>Lanches  { get; set; }
    }
}   


