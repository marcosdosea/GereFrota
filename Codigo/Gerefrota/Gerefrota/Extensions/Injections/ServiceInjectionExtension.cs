using Microsoft.Extensions.DependencyInjection;

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
            return collection;
        }
    }
}
