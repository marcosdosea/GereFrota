using System;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Entities;

namespace Domain.Abstract.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario GetUsuarioByLoginAndPass(Func<Usuario, bool> match);
    }
}
