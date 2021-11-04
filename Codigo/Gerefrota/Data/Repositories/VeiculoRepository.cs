using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        private readonly ContextDB _context;
        public VeiculoRepository(ContextDB context) : base(context) => _context = context;

        public IEnumerable<Veiculo> GetAllVeiculoByFrota(int idFrota)
            => _context.Veiculo.Where(v => v.Id == idFrota);
    }
}
