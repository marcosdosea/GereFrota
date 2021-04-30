using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class SolicitacoesManutencaoService : BaseService<SolicitacoesManutencaoModel, SolicitacoesManutencao, IBaseRepository<SolicitacoesManutencao>>, ISolicitacoesManutencaoService
    {
        public SolicitacoesManutencaoService(IBaseRepository<SolicitacoesManutencao> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
