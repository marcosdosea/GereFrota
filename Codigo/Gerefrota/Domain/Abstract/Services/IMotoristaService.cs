using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs;
using System.Collections.Generic;

namespace Domain.Abstract.Services
{
    public interface IMotoristaService : IBaseService<MotoristaModel, Motorista>
    {
        IEnumerable<MotoristaUserModel> ObterMotoristasPorUnidade(int idUnidade);
    }
}