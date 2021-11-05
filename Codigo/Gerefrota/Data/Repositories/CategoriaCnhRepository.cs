using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class CategoriaCnhRepository : BaseRepository<CategoriaCnh>, ICategoriaCnhRepository
    {
        public CategoriaCnhRepository(ContextDB context) : base(context) { }
    }
}
