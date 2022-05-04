using Venda_de_lanches.Models;

namespace Venda_de_lanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        
        Lanche GetLancheById(int lancheId);
    }
}
