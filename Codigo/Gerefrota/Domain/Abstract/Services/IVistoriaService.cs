using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs.DTO;
using System.Threading.Tasks;

namespace Domain.Abstract.Services
{
    public interface IVistoriaService : IBaseService<VistoriaModel, Vistoria>
    {
        /// <summary>
        /// Trata os objetos internos ao DTO para os respectivos serviços.
        /// Adiciona as avarias (caso haja).
        /// </summary>
        /// <param name="vistoriaDTO">objeto contendo informações da pagina.</param>
        /// <returns>booleano indicando que foi inserido com sucesso.</returns>
        Task<bool> Insert(VistoriaDTO vistoriaDTO);
    }
}
