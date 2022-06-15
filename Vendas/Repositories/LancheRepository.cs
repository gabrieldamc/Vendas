using Microsoft.EntityFrameworkCore;
using System.Linq;
using Vendas.Context;
using Vendas.Models;
using Vendas.Repositories.Interfaces;

namespace Vendas.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int Lancheid)
        { 
            return _context.Lanches.FirstOrDefault(I => I.LancheId == Lancheid);
        }
        
    }
}
