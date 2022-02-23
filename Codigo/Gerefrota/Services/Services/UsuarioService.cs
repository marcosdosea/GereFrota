using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs;
using Services.Services.BaseService;
using System;
using System.Linq;
using System.Text.RegularExpressions;

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

        public UserAndTypeModel GetUsuarioByLoginAndPass(UserLogin userLogin)
        {
            var onlyDigits = Regex.Replace(userLogin.Username, "[^0-9a-zA-Z]+", "");
            var isCpf = onlyDigits.All(c => char.IsDigit(c));
            Func<Usuario, bool> match = isCpf
                ? (y) => y.Cpf == onlyDigits && y.Senha == userLogin.Password
                : (y) => y.Email == userLogin.Username && y.Senha == userLogin.Password;

            return _mapper.Map<UserAndTypeModel>(_repo.GetUsuarioByLoginAndPass(match));
        }
    }
}