using System;
using System.Linq;
using System.Linq.Expressions;
using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Aux;
using Domain.Entities.Context;
using Domain.Models.Aux;

namespace Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly ContextDB _context;
        public UsuarioRepository(ContextDB context) : base(context) => _context = context;

        public UserAndType GetUsuarioByLoginAndPass(Func<UserAndType, bool> match)
            => _context.Usuario
                    .Join(_context.TipoUsuario,
                            u => u.IdTipoUsuario,
                            tu => tu.Id,
                            (u, tu) => new UserAndType { Usuario = u, TipoUsuario = tu })
                    .Where(match).FirstOrDefault();
    }
}
