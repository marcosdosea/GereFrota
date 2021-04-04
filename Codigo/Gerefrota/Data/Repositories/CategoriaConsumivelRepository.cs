using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class CategoriaConsumivelRepository : BaseRepository<CategoriaConsumivel>, ICategoriaConsumivelRepository
    {
        public CategoriaConsumivelRepository(ContextDB context) : base(context) { }
    }
}
