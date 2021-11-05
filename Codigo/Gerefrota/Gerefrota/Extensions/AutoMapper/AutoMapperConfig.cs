using AutoMapper;
using Domain.Entities;
using Domain.Entities.Auxs;
using Domain.Models;
using Domain.Models.Auxs;

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

                // Aux Models.
                cfg.CreateMap<UserAndType, UserAndTypeModel>().ReverseMap();
                cfg.CreateMap<VeiculoESolicitacaoManutencao, VeiculoESolicitacaoManutencaoModel>().ReverseMap();
                cfg.CreateMap<MotoristaUser, MotoristaUserModel>().ReverseMap();
            });

            return configuration.CreateMapper();
        }
    }
}
