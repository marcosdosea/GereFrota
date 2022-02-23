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
            // Ele injetará todos os Repositorios que estão sendo chamados.
            collection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            collection.AddScoped<IUsuarioRepository, UsuarioRepository>();
            collection.AddScoped<IVeiculoRepository, VeiculoRepository>();
            collection.AddScoped<IFrotaRepository, FrotaRepository>();
            collection.AddScoped<IMotoristaRepository, MotoristaRepository>();
            collection.AddScoped<IAvariasRepository, AvariasRepository>();
            collection.AddScoped<IComponenteRepository, ComponenteRepository>();
            collection.AddScoped<IVistoriaRepository, VistoriaRepository>();

            return collection;
        }
    }
}
