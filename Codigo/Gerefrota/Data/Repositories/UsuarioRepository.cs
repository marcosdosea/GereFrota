using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Auxs;
using Domain.Entities.Context;
using System;
using System.Linq;

namespace Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly ContextDB _context;
        public UsuarioRepository(ContextDB context) : base(context) => _context = context;

        public UserAndType GetUsuarioByLoginAndPass(Func<Usuario, bool> match)
            => _context.Usuario
                        .Where(match).ToArray()
                        .Join(_context.TipoUsuario,
                              u => u.IdTipoUsuario,
                              tu => tu.Id,
                              (u, tu) => new UserAndType { Usuario = u, TipoUsuario = tu })
                        .FirstOrDefault();
    }
}
