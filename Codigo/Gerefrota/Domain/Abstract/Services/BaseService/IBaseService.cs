using System.Collections.Generic;

namespace Domain.Abstract.Services.BaseService
{
    public interface IBaseService<T>
    {
        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser inserido.</param>
        /// <returns></returns>
        T Insert(T obj);

        /// <summary>
        /// Atualiza um objeto da base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado</param>
        /// <returns>Retorna o objeto atualizado</returns>
        T Update(T obj);

        /// <summary>
        /// Remove um objeto da base de dados
        /// </summary>
        /// <param name="obj">Objeto a ser deletado da base</param>
        /// <returns>Retorna se o objeto foi deletado ou não.</returns>
        bool Delete(T obj);

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <returns>Retorna uma lista de itens.</returns>
        List<T> GetAll();

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <param name="id">Id do objeto a ser buscado</param>
        /// <returns>Retorna um uma entidade.</returns>
        T Get(int id);

    }
}
