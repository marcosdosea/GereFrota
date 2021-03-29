using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class AbastecimentoRepository : BaseRepository<Abastecimento>, IAbastecimentoRepository
    {
        public AbastecimentoRepository(ContextDB context) : base(context) { }
    }
}
