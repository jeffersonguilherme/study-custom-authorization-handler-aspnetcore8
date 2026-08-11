using AuthDemo.DTOs;
using AuthDemo.Entities;
using AuthDemo.Interfaces;
using AuthDemo.Responses;
using Microsoft.AspNetCore.Identity;

namespace AuthDemo.Services.Auth;

public class AuthService : IAuthInterface
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IRoleMatriculaRepository _roleMatricula;

    public AuthService(UserManager<ApplicationUser> userManager, IRoleMatriculaRepository roleMatricula)
    {
        _userManager = userManager;
        _roleMatricula = roleMatricula;
    }


    public async Task<ResponseModel<string>> Register(RegisterDto registerDto)
    {
        ResponseModel<string> response = new ResponseModel<string>();
        try
        {
            var role = await _roleMatricula.GetRoleAsync(registerDto.Matricula);
            var user = new ApplicationUser
            {
              Email = registerDto.Email,
              NomeCompleto = registerDto.NomeCompleto,
              UserName = registerDto.Usuario,
              Matricula = registerDto.Matricula,
            };

            var result = await _userManager.CreateAsync(user, registerDto.Senha);
            if(!result.Succeeded)
            {
                response.Mensagem = string.Join(" | ", result.Errors.Select(e => e.Description));
                response.Status = false;
                return response;
            }

            await _userManager.AddToRoleAsync(user, role);

                    response.Dados = user.Id;
                    response.Mensagem = "Usuário cadastrado com sucesso";
                    response.Status = true;
                    return response;
            
        }catch(Exception ex)
        {
            response.Mensagem = ex.Message;
            response.Status = false;
            return response;
        }
    }
}