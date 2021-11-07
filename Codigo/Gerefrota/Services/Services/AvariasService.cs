using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class AvariasService : BaseService<AvariasModel, Avarias, IBaseRepository<Avarias>>, IAvariasService
    {
        public AvariasService(IBaseRepository<Avarias> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
