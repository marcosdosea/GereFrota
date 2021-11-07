using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Abstract.Repositories.BaseRepository
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser inserido.</param>
        /// <returns></returns>
        Task<T> Insert(T obj);

        /// <summary>
        /// Atualiza um objeto da base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado</param>
        /// <returns>Retorna o objeto atualizado</returns>
        Task<T> Update(T obj);

        /// <summary>
        /// Remove um objeto da base de dados
        /// </summary>
        /// <param name="obj">Objeto a ser deletado da base</param>
        /// <returns>Retorna se o objeto foi deletado ou não.</returns>
        Task<bool> Delete(T obj);

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <param name="filter">Filtro a ser utilizado, ex: "x => x.id == id"</param>
        /// <returns>Retorna um IQueryable resultante daquele filtro.</returns>
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null);
    }
}
