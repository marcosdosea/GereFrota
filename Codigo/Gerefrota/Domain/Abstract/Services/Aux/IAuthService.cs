using System;
using Domain.Models;

namespace Domain.Abstract.Services.Aux
{
    public interface IAuthService
    {
        string GenerateToken(UsuarioModel user);
    }
}

