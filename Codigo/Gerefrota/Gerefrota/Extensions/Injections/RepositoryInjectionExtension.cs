using Data.Repositories;
using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Microsoft.Extensions.DependencyInjection;

namespace Gerefrota.Extensions.Injections
{
    public static class RepositoryInjectionExtension
    {
        /// <summary>
        /// Realiza a injeção dos repositorios no startup.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositoryInjection(this IServiceCollection collection)
        {
            #region BASE
            collection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            #endregion
            collection.AddScoped<IUnidadeRepository, UnidadeRepository>();
            collection.AddScoped<ICategoriaCnhRepository, CategoriaCnhRepository>();
            collection.AddScoped<IAbastecimentoRepository, AbastecimentoRepository>();

            return collection;
        }
    }
}
