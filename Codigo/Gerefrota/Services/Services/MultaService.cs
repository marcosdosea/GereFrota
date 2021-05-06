using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class MultaService : BaseService<MultaModel, Multa, IBaseRepository<Multa>>, IMultaService
    {
        public MultaService(IBaseRepository<Multa> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
