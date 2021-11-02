using System;
using System.Linq;
using System.Linq.Expressions;
using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly ContextDB _context;
        public UsuarioRepository(ContextDB context) : base(context) => _context = context;

        public Usuario GetUsuarioByLoginAndPass(Func<Usuario, bool> match)
            => _context.Usuario.Where(match).FirstOrDefault();
    }
}
