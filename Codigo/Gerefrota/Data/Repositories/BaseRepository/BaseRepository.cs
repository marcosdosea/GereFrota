using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Repositories.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly ContextDB _context;
        public BaseRepository(ContextDB context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Remove um objeto da base de dados
        /// </summary>
        /// <param name="obj">Objeto a ser deletado da base</param>
        /// <returns></returns>
        public async Task<bool> Delete(T obj)
        {
            _dbSet.Remove(obj);
            return await _context.SaveChangesAsync() == 1;
        }

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <param name="filter">Filtro a ser utilizado, ex: "x => x.id == id"</param>
        /// <returns>Retorna um IQueryable resultante daquele filtro.</returns>
        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null) => filter is not null ? _dbSet.Where(filter) : _dbSet;

        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser inserido.</param>
        /// <returns></returns>
        public async Task<T> Insert(T obj)
        {
            var entry = await _dbSet.AddAsync(obj);
            return await _context.SaveChangesAsync() == 1 ? entry.Entity : null;
        }

        /// <summary>
        /// Atualiza um objeto da base de dados.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Retorna o objeto atualizado</returns>
        public async Task<T> Update(T obj)
        {
            var entidade = _dbSet.Update(obj).Entity;
            return await _context.SaveChangesAsync() == 1 ? entidade : null;
        }
    }
}
