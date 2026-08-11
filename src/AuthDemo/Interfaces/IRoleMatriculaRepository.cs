namespace AuthDemo.Interfaces;

public interface IRoleMatriculaRepository
{
    Task<string> GetRoleAsync(string matricula);
}