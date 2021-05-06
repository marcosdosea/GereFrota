using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;

namespace Domain.Abstract.Services
{
    public interface IUsuarioService : IBaseService<UsuarioModel, Usuario> { }
}
