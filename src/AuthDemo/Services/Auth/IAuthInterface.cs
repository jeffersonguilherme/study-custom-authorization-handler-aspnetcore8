using Responses;

namespace AuthDemo.Services.Auth;

public interface IAuthInterface
{
    Task<ResponseModel<string>> Register(RegisterDto registerDto);
}