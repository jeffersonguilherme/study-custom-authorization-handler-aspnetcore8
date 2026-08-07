using Microsoft.AspNetCore.Identity;

namespace AuthDemo.Entities;

public class ApplicationUser : IdentityUser
{
    public string NomeCompleto { get; set; } = string.Empty;
    public string Matricula { get; set; } = string.Empty;
}