using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Abstract.Repositories
{
    public interface IVeiculoRepository : IBaseRepository<Veiculo>
    {
        IEnumerable<Veiculo> GetAllVeiculoByFrota(int idFrota);
    }
}
