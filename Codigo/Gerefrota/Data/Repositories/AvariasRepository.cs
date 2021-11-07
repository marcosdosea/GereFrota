using Data.Repositories.BaseRepository;
using Domain.Abstract.Repositories;
using Domain.Entities;
using Domain.Entities.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AvariasRepository : BaseRepository<Avarias>, IAvariasRepository
    {
        private readonly ContextDB _context;
        public AvariasRepository(ContextDB context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> Insert(ICollection<Avarias> avarias)
        {
            await _context.Avarias.AddRangeAsync(avarias);
            return await _context.SaveChangesAsync() == avarias.Count;
        }
    }
}
