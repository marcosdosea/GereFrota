using System.Collections.Generic;
using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;

namespace Domain.Abstract.Services
{
    public interface IFrotaService : IBaseService<FrotaModel, Frota>
    {
        IEnumerable<FrotaModel> ObterTodasAsFrotasPorUnidade(int idUnidade);
    }
}
