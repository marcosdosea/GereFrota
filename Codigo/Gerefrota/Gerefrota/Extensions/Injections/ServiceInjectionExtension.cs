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
            collection.AddScoped<IAbastecimentoService, AbastecimentoService>();
            collection.AddScoped<ICategoriaCnhService, CategoriaCnhService>();
            collection.AddScoped<ICategoriaConsumivelService, CategoriaConsumivelService>();
            collection.AddScoped<IConsumivelVeicularService, ConsumivelVeicularService>();
            collection.AddScoped<IFrotaService, FrotaService>();
            collection.AddScoped<ITipoUsuarioService, TipoUsuarioService>();
            collection.AddScoped<IUsuarioService, UsuarioService>();
            collection.AddScoped<IVeiculoService, VeiculoService>();
            collection.AddScoped<IViagemService, ViagemService>();
            collection.AddScoped<IVistoriaService, VistoriaService>();
            collection.AddScoped<IMotoristaService, MotoristaService>();
            collection.AddScoped<IMultaService, MultaService>();
            collection.AddScoped<IRelatorioMecanicoService, RelatorioMecanicoService>();
            collection.AddScoped<ISolicitacoesManutencaoService, SolicitacoesManutencaoService>();
            collection.AddScoped<IStatusSolicitacaoService, StatusSolicitacaoService>();
            collection.AddScoped<ITiposManutencaoService, TiposManutencaoService>();
            collection.AddScoped<IUnidadeService, UnidadeService>();

            return collection;
        }
    }
}
