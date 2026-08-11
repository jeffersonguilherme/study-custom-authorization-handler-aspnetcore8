using AuthDemo.Data;
using AuthDemo.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Repository;

public class RoleMatriculaRepository : IRoleMatriculaRepository
{
    private readonly ApplicationDBContext _context;
public RoleMatriculaRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<string> GetRoleAsync(string matricula)
    {
        var role = await _context.MatriculaRoles.FirstOrDefaultAsync(mat => mat.Matricula == matricula);
        if(role is null)
         throw  new ArgumentException("Matricula não cadastrada");

        return role.Role;
    }
}