using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class TiposManutencaoService : BaseService<TiposManutencaoModel, TiposManutencao, IBaseRepository<TiposManutencao>>, ITiposManutencaoService
    {
        public TiposManutencaoService(IBaseRepository<TiposManutencao> repo, IMapper mapper) : base(repo, mapper) { }
    }
    
}
