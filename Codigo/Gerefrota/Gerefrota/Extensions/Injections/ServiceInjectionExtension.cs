using Domain.Abstract.Services;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace Gerefrota.Extensions.Injections
{
    public static class ServiceInjectionExtension
    {
        /// <summary>
        /// Realiza a injeção de dependencia da camada de serviço.
        /// </summary>
        /// <param name="collection">Coleção de informações do startup</param>
        /// <returns></returns>
        public static IServiceCollection AddServiceInjection(this IServiceCollection collection)
        {
            collection.AddScoped<IUnidadeService, UnidadeService>();
            collection.AddScoped<ICategoriaCnhService, CategoriaCnhService>();
            collection.AddScoped<ICategoriaConsumivelService, CategoriaConsumivelService>();
            collection.AddScoped<IAbastecimentoService, AbastecimentoService>();

            return collection;
        }
    }
}
