using Data.Repositories;
using Domain.Abstract.Repositories;
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
            collection.AddScoped<IUnidadeRepository, UnidadeRepository>();
            collection.AddScoped<ICategoriaCnhRepository, CategoriaCnhRepository>();
            collection.AddScoped<IAbastecimentoRepository, AbastecimentoRepository>();

            return collection;
        }
    }
}
