using Domain.Abstract.Services.BaseService;
using Domain.Models;

namespace Domain.Abstract.Services
{
    public interface IUnidadeService : IBaseService<UnidadeModel>
    {
        UnidadeModel GetBySigla(string sigla);
    }
}
