namespace AuthDemo.DTOs;

public class RegisterDto
{
    public string Email { get; set; } = string.Empty;
    public string NomeCompleto { get; set; } = string.Empty;
    public string Usuario { get; set; } = string.Empty;
    public string Matricula { get; set; } = string.Empty;
    public List<string> Roles { get; set; } = new();

}