using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Abstract.Repositories
{
    public interface IAvariasRepository : IBaseRepository<Avarias>
    {
        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="avarias">Lista de avarias que será inserido.</param>
        /// <returns>booleano indicando que foi inserido com sucesso.</returns>
        Task<bool> Insert(ICollection<Avarias> avarias);
    }
}
