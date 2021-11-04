using System;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using Domain.Entities.Auxs;

namespace Domain.Abstract.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        UserAndType GetUsuarioByLoginAndPass(Func<UserAndType, bool> match);
    }
}
