using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Auxs;
using Domain.Entities.Context;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class MotoristaRepository : BaseRepository<Motorista>, IMotoristaRepository
    {
        private readonly ContextDB _context;
        public MotoristaRepository(ContextDB context) : base(context) => _context = context;

        /// <summary>
        /// SUMARIO DAS SOLICITAÇÕES
        /// 1 - MOTORISTA
        /// 2 - GESTOR
        /// 3 - ADM
        /// </summary>
        /// <param name="idFrota"></param>
        /// <returns></returns>
        public IEnumerable<MotoristaUser> ObterMotoristasPorUnidade(int idUnidade)
            => _context.Usuario
                        .Where(u => u.IdUnidade == idUnidade && u.IdTipoUsuario == 1) // TODO: Trocar por ENUM futuramente
                        .Join(_context.Motorista,
                                u => u.Id,
                                m => m.IdUsuario,
                                (u, m) => new MotoristaUser
                                {
                                    Usuario = u,
                                    Motorista = m
                                });


    }
}
