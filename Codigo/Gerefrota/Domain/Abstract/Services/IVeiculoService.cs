using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs;
using System.Collections.Generic;

namespace Domain.Abstract.Services
{
    public interface IVeiculoService : IBaseService<VeiculoModel, Veiculo>
    {
        IEnumerable<VeiculoModel> ObterTodosVeiculosDaFrota(int idFrota);
        IEnumerable<VeiculoESolicitacaoManutencaoModel> GetAllVeiculosAndSolicitacao(int idFrota);
    }
}
