using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class TipoUsuarioService : BaseService<TipoUsuarioModel, TipoUsuario, IBaseRepository<TipoUsuario>>, ITipoUsuarioService
    {
        public TipoUsuarioService(IBaseRepository<TipoUsuario> genericRepo, IMapper mapper) : base(genericRepo, mapper) { }
    }
}
