using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class StatusSolicitacaoService : BaseService<StatusSolicitacaoModel, StatusSolicitacao, IBaseRepository<StatusSolicitacao>>, IStatusSolicitacaoService
    {
        public StatusSolicitacaoService(IBaseRepository<StatusSolicitacao> repo, IMapper mapper) : base(repo, mapper) { }
    }
}