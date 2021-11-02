using System;
using System.Linq;
using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Aux;
using Services.Services.BaseService;

namespace Services.Services
{
    public class UsuarioService : BaseService<UsuarioModel, Usuario, IBaseRepository<Usuario>>, IUsuarioService
    {
        private readonly IUsuarioRepository _repo;
        private readonly IMapper _mapper;
        public UsuarioService(IMapper mapper, IUsuarioRepository uRepo) : base(uRepo, mapper)
        {
            _repo = uRepo;
            _mapper = mapper;
        }

        public UsuarioModel GetUsuarioByLoginAndPass(UserLogin userLogin)
        {
            var isCpf = userLogin.Username.All(c => char.IsDigit(c)); // check if is digit
            Func<Usuario, bool> match = isCpf
                ? (y) => y.Cpf == userLogin.Username.Replace("[^0-9a-zA-Z]+", "") && y.Senha == userLogin.Password
                : (y) => y.Email == userLogin.Username && y.Senha == userLogin.Password;

            return _mapper.Map<UsuarioModel>(_repo.GetUsuarioByLoginAndPass(match));
        }
    }
}