using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class VistoriaService : BaseService<VistoriaModel, Vistoria, IBaseRepository<Vistoria>>, IVistoriaService
    {
        public VistoriaService(IBaseRepository<Vistoria> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
