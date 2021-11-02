using System.Collections.Generic;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;

namespace Domain.Abstract.Repositories
{
    public interface IFrotaRepository : IBaseRepository<Frota>
    {
        IEnumerable<Frota> GetAllFrotasByUnidade(int idUnidade);
    }
}
