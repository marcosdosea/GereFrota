using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class CategoriaConsumivelService : BaseService<CategoriaConsumivelModel, CategoriaConsumivel, IBaseRepository<CategoriaConsumivel>>, ICategoriaConsumivelService
    {
        public CategoriaConsumivelService(IBaseRepository<CategoriaConsumivel> baseRepo, IMapper mapper) : base(baseRepo, mapper) { }
    }
}
