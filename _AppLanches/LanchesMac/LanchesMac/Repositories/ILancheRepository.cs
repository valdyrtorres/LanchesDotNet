using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LachesPreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
