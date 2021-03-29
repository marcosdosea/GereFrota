using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Services.Services.BaseService
{
    public class BaseService<TModel, TEntity, TRepositoryInterface> : IBaseService<TModel, TEntity> where TRepositoryInterface : IBaseRepository<TEntity>
    {
        private readonly TRepositoryInterface _repositoryInterface;
        private readonly IMapper _mapper;

        public BaseService(TRepositoryInterface genericInterface, IMapper mapper)
        {
            _repositoryInterface = genericInterface;
            _mapper = mapper;
        }

        public bool Delete(TModel obj) => _repositoryInterface.Delete(_mapper.Map<TEntity>(obj));

        public TModel Get(Expression<Func<TEntity, bool>> filter = null) => _mapper.Map<TEntity, TModel>(_repositoryInterface.Get(filter).FirstOrDefault());

        public List<TModel> GetAll() => _repositoryInterface.Get(_ => true).Select(x => _mapper.Map<TModel>(x)).ToList();

        public TModel Insert(TModel obj) => _mapper.Map<TModel>(_repositoryInterface.Insert(_mapper.Map<TEntity>(obj)));

        public TModel Update(TModel obj) => _mapper.Map<TModel>(_repositoryInterface.Update(_mapper.Map<TEntity>(obj)));
    }
}
