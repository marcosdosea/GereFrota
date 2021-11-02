using System.Collections.Generic;
using System.Linq;
using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class FrotaRepository : BaseRepository<Frota>, IFrotaRepository
    {
        private readonly ContextDB _context;
        public FrotaRepository(ContextDB context) : base(context) => _context = context;

        public IEnumerable<Frota> GetAllFrotasByUnidade(int idUnidade)
            => _context.Frota.Where(f => f.IdUnidade == idUnidade);
    }
}
