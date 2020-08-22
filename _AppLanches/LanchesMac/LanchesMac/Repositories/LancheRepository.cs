using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Repositories
{

    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        IEnumerable<Lanche> ILancheRepository.Lanches => _context.Lanches.Include(c => c.Categoria);

        IEnumerable<Lanche> ILancheRepository.LachesPreferidos => _context.Lanches.Where(p => 
                p.IsLanchePreferido).Include(c => c.Categoria);

        Lanche ILancheRepository.GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
