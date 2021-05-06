using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class VistoriaRepository : BaseRepository<Vistoria>, IVistoriaRepository
    {
        public VistoriaRepository(ContextDB context) : base(context) { }
    }
}
