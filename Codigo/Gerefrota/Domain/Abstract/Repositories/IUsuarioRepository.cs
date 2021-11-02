using System;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using Domain.Entities.Aux;

namespace Domain.Abstract.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        UserAndType GetUsuarioByLoginAndPass(Func<UserAndType, bool> match);
    }
}
