using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Abstract.Services
{
    public interface IFrotaService : IBaseService<FrotaModel, Frota>
    {
        IEnumerable<FrotaModel> ObterTodasAsFrotasPorUnidade(int idUnidade);
    }
}
