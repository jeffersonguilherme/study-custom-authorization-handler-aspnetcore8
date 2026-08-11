using AuthDemo.Interfaces;
using AuthDemo.Responses;

namespace AuthDemo.Repository;

public class RoleMatriculaRepository : IRoleMatriculaRepository
{
    public Task<ResponseModel<string>> GetRoleAsync(string matricula)
    {
        throw new NotImplementedException();
    }
}