using AuthDemo.DTOs;
using AuthDemo.Responses;

namespace AuthDemo.Interfaces;

public interface IRoleMatriculaRepository
{
    Task<string> GetRoleAsync(string matricula);
    Task<ResponseModel<string>> AddRole(MatriculaRoleDto matriculaRoleDto);
}