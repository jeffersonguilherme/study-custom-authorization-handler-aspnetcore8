using AuthDemo.Data;
using AuthDemo.DTOs;
using AuthDemo.EntitiesEntities;
using AuthDemo.Interfaces;
using AuthDemo.Responses;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Repository;

public class RoleMatriculaRepository : IRoleMatriculaRepository
{
    private readonly ApplicationDBContext _context;
public RoleMatriculaRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<ResponseModel<string>> AddRole(MatriculaRoleDto matriculaRoleDto)
    {
        ResponseModel<string> response = new ResponseModel<string>();
        try
        {
            var matriculaRole = new MatriculaRole
            {
            Matricula = matriculaRoleDto.Matricula,
            Role = matriculaRoleDto.Role
        };

        await _context.MatriculaRoles.AddAsync(matriculaRole);
        await _context.SaveChangesAsync();

      response.Dados = matriculaRole.Id.ToString();
        response.Mensagem = "Role vinculada à matrícula com sucesso";
        response.Status = true;
        return response;
    }
    catch (Exception ex)
    {
        response.Mensagem = ex.Message;
        response.Status = false;
        return response;
    }
    }

    public async Task<string> GetRoleAsync(string matricula)
    {
        var role = await _context.MatriculaRoles.FirstOrDefaultAsync(mat => mat.Matricula == matricula);
        if(role is null)
         throw  new ArgumentException("Matricula não cadastrada");

        return role.Role;
    }
}