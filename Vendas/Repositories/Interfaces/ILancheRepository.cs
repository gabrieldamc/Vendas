using Vendas.Context;
using Vendas.Models;

namespace Vendas.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }        
        Lanche GetLancheById(int Lancheid);
    }
}
