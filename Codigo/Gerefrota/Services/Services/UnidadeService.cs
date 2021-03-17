using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class UnidadeService : IUnidadeService
    {
        private readonly IUnidadeRepository _unidadeRepo;
        private readonly IMapper _mapper;
        public UnidadeService(IUnidadeRepository unidadeRepo, IMapper mapper)
        {
            _unidadeRepo = unidadeRepo;
            _mapper = mapper;
        }

        // Exemplo de retorno / Mapeamento automatizado.
        public UnidadeModel GetBySigla(string sigla)
        {
            var unidadeBanco = _unidadeRepo.Get(u => u.Sigla.Equals(sigla)).FirstOrDefault();

            return _mapper.Map<UnidadeModel>(unidadeBanco);
        }

        public bool Delete(UnidadeModel obj) => _unidadeRepo.Delete(_mapper.Map<Unidade>(obj));

        public UnidadeModel Get(int id) => _mapper.Map<UnidadeModel>(_unidadeRepo.Get(x => x.Id == id).FirstOrDefault());

        public List<UnidadeModel> GetAll() => _unidadeRepo.Get().Select(x => _mapper.Map<UnidadeModel>(x)).ToList();

        public UnidadeModel Insert(UnidadeModel obj) => _mapper.Map<UnidadeModel>(_unidadeRepo.Insert(_mapper.Map<Unidade>(obj)));

        public UnidadeModel Update(UnidadeModel obj) => _mapper.Map<UnidadeModel>(_unidadeRepo.Update(_mapper.Map<Unidade>(obj)));
    }
}
