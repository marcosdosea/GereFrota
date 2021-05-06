using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class MultaRepository : BaseRepository<Multa>, IMultaRepository 
    {
        public MultaRepository(ContextDB context) : base(context) { }
    }
}