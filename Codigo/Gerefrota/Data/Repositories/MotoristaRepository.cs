using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class MotoristaRepository : BaseRepository<Motorista>, IMotoristaRepository
    {
        public MotoristaRepository(ContextDB context) : base(context) { }
    }
}
