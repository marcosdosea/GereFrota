using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class ConsumivelVeicularService : BaseService<ConsumivelVeicularModel, ConsumivelVeicular, IBaseRepository<ConsumivelVeicular>>, IConsumivelVeicularService
    {
        public ConsumivelVeicularService(IBaseRepository<ConsumivelVeicular> baseRepository, IMapper mapper) : base(baseRepository, mapper) { }
    }
}
