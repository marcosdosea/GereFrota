using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using Domain.Entities.Auxs;
using System.Collections.Generic;

namespace Domain.Abstract.Repositories
{
    public interface IVeiculoRepository : IBaseRepository<Veiculo>
    {
        IEnumerable<Veiculo> GetAllVeiculoByFrota(int idFrota);

        /// <summary>
        /// SUMARIO DAS SOLICITAÇÕES
        /// 0 - Concluída
        /// 1 - Em Aberto
        /// 2 - Em Andamento
        /// </summary>
        /// <param name="idFrota"></param>
        /// <returns></returns>
        IEnumerable<VeiculoESolicitacaoManutencao> GetAllVeiculosAndSolicitacao(int idFrota, bool withConcluida = false);
    }
}
