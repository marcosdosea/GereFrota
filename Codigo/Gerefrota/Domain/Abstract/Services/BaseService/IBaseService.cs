using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Abstract.Services.BaseService
{
    public interface IBaseService<TModel, TEntity>
    {
        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser inserido.</param>
        /// <returns></returns>
        Task<TModel> Insert(TModel obj);

        /// <summary>
        /// Atualiza um objeto da base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado</param>
        /// <returns>Retorna o objeto atualizado</returns>
        Task<TModel> Update(TModel obj);

        /// <summary>
        /// Remove um objeto da base de dados
        /// </summary>
        /// <param name="obj">Objeto a ser deletado da base</param>
        /// <returns>Retorna se o objeto foi deletado ou não.</returns>
        Task<bool> Delete(TModel obj);

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <returns>Retorna uma lista de itens.</returns>
        IEnumerable<TModel> GetAll(Expression<Func<TEntity, bool>> filter = null);

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <param name="filter">Filtro do objeto a ser buscado</param>
        /// <returns>Retorna um uma entidade.</returns>
        TModel Get(Expression<Func<TEntity, bool>> filter = null);

    }
}
