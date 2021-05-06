using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Services.Services.BaseService;

namespace Services.Services
{
    public class UsuarioService : BaseService<UsuarioModel, Usuario, IBaseRepository<Usuario>>, IUsuarioService
    {
        public UsuarioService(IBaseRepository<Usuario> repo, IMapper mapper) : base(repo, mapper) { }
    }
}
