using AuthDemo.Responses;

namespace AuthDemo.Interfaces;

public interface IRoleMatriculaRepository
{
    Task<ResponseModel<string>> GetRoleAsync(string matricula);
}