using AutoMapper;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        public async Task<bool> Delete(TModel obj) => await _repositoryInterface.Delete(_mapper.Map<TEntity>(obj));

        public TModel Get(Expression<Func<TEntity, bool>> filter) => _mapper.Map<TEntity, TModel>(_repositoryInterface.Get(filter).FirstOrDefault());

        public IEnumerable<TModel> GetAll(Expression<Func<TEntity, bool>> filter = null) => _repositoryInterface.Get(filter).Select(x => _mapper.Map<TModel>(x));

        public async Task<TModel> Insert(TModel obj) => _mapper.Map<TModel>(await _repositoryInterface.Insert(_mapper.Map<TEntity>(obj)));

        public async Task<TModel> Update(TModel obj) => _mapper.Map<TModel>(await _repositoryInterface.Update(_mapper.Map<TEntity>(obj)));
    }
}
