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
    public class MotoristaService : BaseService<MotoristaModel, Motorista, IBaseRepository<Motorista>>, IMotoristaService
    {
        private readonly IMotoristaRepository _repo;
        private readonly IMapper _mapper;
        public MotoristaService(IMotoristaRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<MotoristaUserModel> ObterMotoristasPorUnidade(int idUnidade)
        {
            var motoristas = _repo.ObterMotoristasPorUnidade(idUnidade);
            return _mapper.Map<IEnumerable<MotoristaUserModel>>(motoristas);
        }
    }

}
