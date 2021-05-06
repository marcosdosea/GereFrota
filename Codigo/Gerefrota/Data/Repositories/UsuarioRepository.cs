using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ContextDB context) : base(context) { }
    }
}
