using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Auxs;
using Domain.Entities.Context;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        private readonly ContextDB _context;
        public VeiculoRepository(ContextDB context) : base(context) => _context = context;

        public IEnumerable<Veiculo> GetAllVeiculoByFrota(int idFrota)
            => _context.Veiculo.Where(v => v.IdFrota == idFrota);

        /// <summary>
        /// SUMARIO DAS SOLICITAÇÕES
        /// 1 - Concluída
        /// 2 - Em Aberto
        /// 3 - Em Andamento
        /// </summary>
        /// <param name="idFrota"></param>
        /// <returns></returns>
        public IEnumerable<VeiculoESolicitacaoManutencao> GetAllVeiculosAndSolicitacao(int idFrota, bool withConcluida = false)
            => _context.Veiculo
                        .Where(v => v.IdFrota == idFrota)
                        .Join(
                            _context.SolicitacoesManutencao,
                            veiculo => veiculo.Id,
                            solicitacaoManutencao => solicitacaoManutencao.IdVeiculo,
                            (veiculo, solicitacaoManutencao) => new { veiculo, solicitacaoManutencao })
                        .Join(_context.TiposManutencao,
                                vsm => vsm.solicitacaoManutencao.IdTiposManutencao,
                                tipoManutencao => tipoManutencao.Id,
                                (veiculoSolicitacaoManutencao, tipoManutencao) => new { veiculoSolicitacaoManutencao, tipoManutencao })
                        .Join(_context.StatusSolicitacao,
                                vstm => vstm.veiculoSolicitacaoManutencao.solicitacaoManutencao.IdStatusSolicitacao,
                                stm => stm.Id,
                                (veiculoSolicitacaoStatusManutencao, statusManutencao) => new { veiculoSolicitacaoStatusManutencao, statusManutencao })
                        .Where(o => o.statusManutencao.Id >= (withConcluida ? 0 : 1)) // Substituir os valores por ENUM pra ficar mais legivel.
                        .Select(o => new VeiculoESolicitacaoManutencao
                        {
                            Veiculo = o.veiculoSolicitacaoStatusManutencao.veiculoSolicitacaoManutencao.veiculo,
                            SolicitacoesManutencao = o.veiculoSolicitacaoStatusManutencao.veiculoSolicitacaoManutencao.solicitacaoManutencao,
                            StatusSolicitacao = o.statusManutencao,
                            TiposManutencao = o.veiculoSolicitacaoStatusManutencao.tipoManutencao
                        });
    }
}
