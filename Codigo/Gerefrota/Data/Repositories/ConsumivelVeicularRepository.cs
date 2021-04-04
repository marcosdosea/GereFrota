using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class ConsumivelVeicularRepository : BaseRepository<ConsumivelVeicular>, IConsumivelVeicularRepository
    {
        public ConsumivelVeicularRepository(ContextDB context) : base(context) { }
    }
}
