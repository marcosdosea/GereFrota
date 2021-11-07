using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class AvariasRepository : BaseRepository<Avarias>, IAvariaRepository
    {
        public AvariasRepository(ContextDB context) : base(context) { }
    }
}
