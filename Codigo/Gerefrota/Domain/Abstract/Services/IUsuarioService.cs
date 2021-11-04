using Domain.Abstract.Services.BaseService;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs;

namespace Domain.Abstract.Services
{
    public interface IUsuarioService : IBaseService<UsuarioModel, Usuario>
    {
        UserAndTypeModel GetUsuarioByLoginAndPass(UserLogin userLogin);
    }
}
