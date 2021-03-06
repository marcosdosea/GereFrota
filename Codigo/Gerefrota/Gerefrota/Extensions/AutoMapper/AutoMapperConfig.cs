using AutoMapper;
using Data.Entities;
using Domain.Models;

namespace Gerefrota.Extensions.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static IMapper CriarMapeamento()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Abastecimento, AbastecimentoModel>().ReverseMap();
                cfg.CreateMap<CategoriaCnh, CategoriaCnhModel>().ReverseMap();
                cfg.CreateMap<CategoriaConsumivel, CategoriaConsumivelModel>().ReverseMap();
                cfg.CreateMap<ConsumivelVeicular, ConsumivelVeicularModel>().ReverseMap();
                cfg.CreateMap<Frota, FrotaModel>().ReverseMap();
                cfg.CreateMap<Motorista, MotoristaModel>().ReverseMap();
                cfg.CreateMap<Multa, MultaModel>().ReverseMap();
                cfg.CreateMap<RelatorioMecanico, RelatorioMecanicoModel>().ReverseMap();
                cfg.CreateMap<SolicitacoesManutencao, SolicitacoesManutencaoModel>().ReverseMap();
                cfg.CreateMap<StatusSolicitacao, StatusSolicitacaoModel>().ReverseMap();
                cfg.CreateMap<TiposManutencao, TiposManutencaoModel>().ReverseMap();
                cfg.CreateMap<TipoUsuario, TipoUsuarioModel>().ReverseMap();
                cfg.CreateMap<Unidade, UnidadeModel>().ReverseMap();
                cfg.CreateMap<Usuario, UsuarioModel>().ReverseMap();
                cfg.CreateMap<Veiculo, VeiculoModel>().ReverseMap();
                cfg.CreateMap<Viagem, ViagemModel>().ReverseMap();
                cfg.CreateMap<Vistoria, VistoriaModel>().ReverseMap();
            });

            return configuration.CreateMapper();
        }
    }
}
