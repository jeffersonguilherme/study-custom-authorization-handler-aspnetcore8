namespace AuthDemo.DTOs;

public class MatriculaRoleDto
{
    public Guid Id { get; set; }
    public string Matricula { get; set; } =string.Empty;
    public string Role { get; set; } = string.Empty;
}