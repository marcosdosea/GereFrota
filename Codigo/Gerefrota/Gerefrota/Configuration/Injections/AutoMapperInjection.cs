using Gerefrota.Configuration.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Gerefrota.Configuration.Injections
{
    public static class AutoMapperInjection
    {
        /// <summary>
        /// Cria o mapeamento das entidades e injeta no container.
        /// </summary>
        /// <param name="collection">Coleção de informações do startup</param>
        /// <returns></returns>
        public static IServiceCollection AddAutoMapperInjection(this IServiceCollection collection)
        {
            collection.AddSingleton(AutoMapperConfig.CriarMapeamento());
            return collection;
        }
    }
}
