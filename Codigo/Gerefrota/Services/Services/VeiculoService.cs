using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class VeiculoService : BaseService<VeiculoModel, Veiculo, IBaseRepository<Veiculo>>, IVeiculoService
    {
        public VeiculoService(IBaseRepository<Veiculo> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
