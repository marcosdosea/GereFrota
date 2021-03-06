using Data.Entities;
using Domain.Abstract.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

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
        public bool Delete(T obj)
        {
            _dbSet.Remove(obj);
            return _context.SaveChanges() == 1;
        }

        /// <summary>
        /// Retorna os itens baseado no filtro que você passar.
        /// </summary>
        /// <param name="filter">Filtro a ser utilizado, ex: "x => x.id == id"</param>
        /// <returns>Retorna um IQueryable resultante daquele filtro.</returns>
        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null) => _dbSet.Where(filter);

        /// <summary>
        /// Insere o objeto na base de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser inserido.</param>
        /// <returns></returns>
        public T Insert(T obj)
        {
            var x = _dbSet.Add(obj).Entity;
            return _context.SaveChanges() == 1 ? x : null;
        }

        /// <summary>
        /// Atualiza um objeto da base de dados.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Retorna o objeto atualizado</returns>
        public T Update(T obj)
        {
            var x = _dbSet.Update(obj).Entity;
            return _context.SaveChanges() == 1 ? x : null;
        }
    }
}
