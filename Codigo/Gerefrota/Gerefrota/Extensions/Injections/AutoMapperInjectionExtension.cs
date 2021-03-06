using Gerefrota.Extensions.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Gerefrota.Extensions.Injections
{
    public static class AutoMapperInjectionExtension
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
