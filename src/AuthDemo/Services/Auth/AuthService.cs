using AuthDemo.DTOs;
using AuthDemo.Responses;

namespace AuthDemo.Services.Auth;

public class AuthService : IAuthInterface
{
    public Task<ResponseModel<string>> Register(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }
}