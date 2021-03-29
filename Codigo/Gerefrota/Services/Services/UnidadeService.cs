using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class UnidadeService : BaseService<UnidadeModel, Unidade, IBaseRepository<Unidade>>, IUnidadeService
    {
        public UnidadeService(IBaseRepository<Unidade> unidadeRepo, IMapper mapper) : base(unidadeRepo, mapper) { }
    }
}
