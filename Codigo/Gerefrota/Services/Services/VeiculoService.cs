using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs;
using Services.Services.BaseService;
using System.Collections.Generic;

namespace Services.Services
{
    public class VeiculoService : BaseService<VeiculoModel, Veiculo, IBaseRepository<Veiculo>>, IVeiculoService
    {
        private readonly IVeiculoRepository _repo;
        private readonly IMapper _mapper;
        public VeiculoService(IVeiculoRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<VeiculoModel> ObterTodosVeiculosDaFrota(int idFrota)
        {
            var veiculos = _repo.GetAllVeiculoByFrota(idFrota);
            return _mapper.Map<IEnumerable<VeiculoModel>>(veiculos);
        }

        public IEnumerable<VeiculoESolicitacaoManutencaoModel> GetAllVeiculosAndSolicitacao(int idFrota)
        {
            var veiculosAndSolicitacoes = _repo.GetAllVeiculosAndSolicitacao(idFrota);
            return _mapper.Map<IEnumerable<VeiculoESolicitacaoManutencaoModel>>(veiculosAndSolicitacoes);
        }
    }
}
