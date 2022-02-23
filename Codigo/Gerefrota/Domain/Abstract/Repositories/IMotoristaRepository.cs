using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using Domain.Entities.Auxs;
using System.Collections.Generic;

namespace Domain.Abstract.Repositories
{
    public interface IMotoristaRepository : IBaseRepository<Motorista>
    {
        IEnumerable<MotoristaUser> ObterMotoristasPorUnidade(int idUnidade);
    }
}
