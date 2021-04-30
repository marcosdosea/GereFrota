using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class StatusSolicitacaoRepository : BaseRepository<StatusSolicitacao>, IStatusSolicitacaoRepository
    {
        public StatusSolicitacaoRepository(ContextDB context) : base(context) { }
    }
}
