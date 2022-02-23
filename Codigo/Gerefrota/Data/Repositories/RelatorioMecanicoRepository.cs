using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class RelatorioMecanicoRepository : BaseRepository<RelatorioMecanico>, IRelatorioMecanicoRepository
    {
        public RelatorioMecanicoRepository(ContextDB context) : base(context) { }
    }
}
