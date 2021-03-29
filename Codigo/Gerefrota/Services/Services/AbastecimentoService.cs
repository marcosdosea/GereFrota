using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class AbastecimentoService : IAbastecimentoService
    {
        private readonly IAbastecimentoRepository _repository;
        private readonly IMapper _mapper;
        public AbastecimentoService(IAbastecimentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(AbastecimentoModel obj) => _repository.Delete(_mapper.Map<Abastecimento>(obj));

        public AbastecimentoModel Get(int id) => _mapper.Map<AbastecimentoModel>(_repository.Get(x => x.Id == id).FirstOrDefault());

        public List<AbastecimentoModel> GetAll() => _repository.Get().Select(x => _mapper.Map<AbastecimentoModel>(x)).ToList();

        public AbastecimentoModel Insert(AbastecimentoModel obj) => _mapper.Map<AbastecimentoModel>(_repository.Insert(_mapper.Map<Abastecimento>(obj)));

        public AbastecimentoModel Update(AbastecimentoModel obj) => _mapper.Map<AbastecimentoModel>(_repository.Update(_mapper.Map<Abastecimento>(obj)));
    }
}
