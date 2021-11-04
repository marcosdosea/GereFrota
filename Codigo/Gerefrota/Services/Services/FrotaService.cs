using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;
using System.Collections.Generic;

namespace Services.Services
{
    public class FrotaService : BaseService<FrotaModel, Frota, IBaseRepository<Frota>>, IFrotaService
    {
        private readonly IFrotaRepository _repo;
        private readonly IMapper _mapper;
        public FrotaService(IFrotaRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<FrotaModel> ObterTodasAsFrotasPorUnidade(int idUnidade)
            => _mapper.Map<IEnumerable<FrotaModel>>(_repo.GetAllFrotasByUnidade(idUnidade));
    }
}
