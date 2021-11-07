using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class ComponenteService : BaseService<ComponenteModel, Componente, IBaseRepository<Componente>>, IComponenteService
    {
        public ComponenteService(IBaseRepository<Componente> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
