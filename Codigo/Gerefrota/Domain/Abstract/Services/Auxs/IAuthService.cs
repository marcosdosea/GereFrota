using System;
using Domain.Models.Auxs;

namespace Domain.Abstract.Services.Auxs
{
    public interface IAuthService
    {
        string GenerateToken(UserAndTypeModel user);
    }
}

