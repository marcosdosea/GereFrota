using System.Collections.Generic;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;

namespace Domain.Abstract.Repositories
{
    public interface IVeiculoRepository : IBaseRepository<Veiculo>
    {
        IEnumerable<Veiculo> GetAllVeiculoByFrota(int idFrota);
    }
}
