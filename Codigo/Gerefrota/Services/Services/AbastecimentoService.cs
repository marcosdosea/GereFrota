using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class AbastecimentoService : BaseService<AbastecimentoModel, Abastecimento, IBaseRepository<Abastecimento>>, IAbastecimentoService
    {
        public AbastecimentoService(IBaseRepository<Abastecimento> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
