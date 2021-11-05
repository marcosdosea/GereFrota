using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using Domain.Entities.Auxs;
using System.Collections.Generic;

namespace Domain.Abstract.Repositories
{
    public interface IVeiculoRepository : IBaseRepository<Veiculo>
    {
        IEnumerable<Veiculo> GetAllVeiculoByFrota(int idFrota);
        IEnumerable<VeiculoESolicitacaoManutencao> GetAllVeiculosAndSolicitacao(int idFrota);
    }
}
