using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AvariasService : BaseService<AvariasModel, Avarias, IBaseRepository<Avarias>>, IAvariasService
    {
        private readonly IAvariasRepository _avariasRepository;
        private readonly IMapper _mapper;
        public AvariasService(IAvariasRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _avariasRepository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Insert(IEnumerable<AvariasModel> avariasModel)
        {
            var avarias = _mapper.Map<ICollection<Avarias>>(avariasModel);
            return await _avariasRepository.Insert(avarias);
        }
    }
}
