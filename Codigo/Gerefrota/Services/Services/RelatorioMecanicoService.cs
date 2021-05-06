using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class RelatorioMecanicoService : BaseService<RelatorioMecanicoModel, RelatorioMecanico, IBaseRepository<RelatorioMecanico>>, IRelatorioMecanicoService
    {
        public RelatorioMecanicoService(IBaseRepository<RelatorioMecanico> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
