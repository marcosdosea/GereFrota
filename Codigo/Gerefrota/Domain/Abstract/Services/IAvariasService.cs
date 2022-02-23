using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Abstract.Services
{
    public interface IAvariasService : IBaseService<AvariasModel, Avarias>
    {
        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="avarias">Lista de avarias que será inserido.</param>
        /// <returns>booleano indicando que foi inserido com sucesso.</returns>
        Task<bool> Insert(IEnumerable<AvariasModel> avarias);
    }
}
