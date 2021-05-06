using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class ViagemService : BaseService<ViagemModel, Viagem, IBaseRepository<Viagem>>, IViagemService
    {
        public ViagemService(IBaseRepository<Viagem> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
