using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Abstract.Repositories
{
    public interface IFrotaRepository : IBaseRepository<Frota>
    {
        IEnumerable<Frota> GetAllFrotasByUnidade(int idUnidade);
    }
}
