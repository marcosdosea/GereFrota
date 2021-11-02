using System.Collections.Generic;
using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;

namespace Domain.Abstract.Services
{
    public interface IVeiculoService : IBaseService<VeiculoModel, Veiculo>
    {
        IEnumerable<VeiculoModel> ObterTodosVeiculosDaFrota(int idFrota);
    }
}
