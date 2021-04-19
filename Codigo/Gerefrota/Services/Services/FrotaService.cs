using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class FrotaService : BaseService<FrotaModel, Frota, IBaseRepository<Frota>>, IFrotaService
    {
        public FrotaService(IBaseRepository<Frota> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
