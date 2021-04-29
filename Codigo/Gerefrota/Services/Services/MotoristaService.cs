using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class MotoristaService : BaseService<MotoristaModel, Motorista, IBaseRepository<Motorista>>, IMotoristaService
    {
        public MotoristaService(IBaseRepository<Motorista> repo, IMapper mapper) : base(repo, mapper) { }
    }
    
}
