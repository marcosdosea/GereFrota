using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class SolicitacoesManutencaoRepository : BaseRepository<SolicitacoesManutencao>, ISolicitacoesManutencaoRepository
    {
        public SolicitacoesManutencaoRepository(ContextDB context) : base(context) { }
    }
}
