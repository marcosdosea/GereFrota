using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Abstract.Services
{
    public interface IVeiculoService : IBaseService<VeiculoModel, Veiculo>
    {
        IEnumerable<VeiculoModel> ObterTodosVeiculosDaFrota(int idFrota);
    }
}
