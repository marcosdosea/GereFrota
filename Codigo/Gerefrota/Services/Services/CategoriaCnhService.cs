using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class CategoriaCnhService : BaseService<CategoriaCnhModel, CategoriaCnh, IBaseRepository<CategoriaCnh>>, ICategoriaCnhService
    {
        public CategoriaCnhService(IBaseRepository<CategoriaCnh> cnhRepository, IMapper mapper) : base(cnhRepository, mapper) { }
    }
}
