using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class ViagemRepository : BaseRepository<Viagem>, IViagemRepository
    {
        public ViagemRepository(ContextDB context) : base(context) { }
    }
}
