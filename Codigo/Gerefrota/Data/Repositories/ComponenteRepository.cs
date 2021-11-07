using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class ComponenteRepository : BaseRepository<Componente>, IComponenteRepository
    {
        public ComponenteRepository(ContextDB context) : base(context)
        {

        }
    }
}
