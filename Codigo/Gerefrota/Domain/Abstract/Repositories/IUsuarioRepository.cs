using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;
using Domain.Entities.Auxs;
using System;

namespace Domain.Abstract.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        UserAndType GetUsuarioByLoginAndPass(Func<Usuario, bool> match);
    }
}
