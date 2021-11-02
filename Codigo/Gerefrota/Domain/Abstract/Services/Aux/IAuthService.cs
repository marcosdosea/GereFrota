using System;
using Domain.Models.Aux;

namespace Domain.Abstract.Services.Aux
{
    public interface IAuthService
    {
        string GenerateToken(UserAndTypeModel user);
    }
}

