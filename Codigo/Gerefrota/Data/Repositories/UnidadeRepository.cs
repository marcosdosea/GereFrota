using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class UnidadeRepository : BaseRepository<Unidade>, IUnidadeRepository
    {
        public UnidadeRepository(ContextDB context) : base(context) { }
    }
}
