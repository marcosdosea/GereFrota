using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class CategoriaCnhService : ICategoriaCnhService
    {
        private readonly ICategoriaCnhRepository _cnhRepository;
        private readonly IMapper _mapper;
        public CategoriaCnhService(ICategoriaCnhRepository cnhRepository, IMapper mapper)
        {
            _cnhRepository = cnhRepository;
            _mapper = mapper;
        }

        public bool Delete(CategoriaCnhModel obj)
        {
            throw new NotImplementedException();
        }

        public CategoriaCnhModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaCnhModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoriaCnhModel Insert(CategoriaCnhModel obj)
        {
            var catCnhBanco = _mapper.Map<CategoriaCnh>(obj);
            var retornoBanco = _cnhRepository.Insert(catCnhBanco);
            return _mapper.Map<CategoriaCnhModel>(retornoBanco);
        }

        public CategoriaCnhModel Update(CategoriaCnhModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
