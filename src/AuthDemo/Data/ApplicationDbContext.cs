using AuthDemo.EntitiesEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Data;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : IdentityDbContext(options)
{
    public DbSet<MatriculaRole> MatriculaRoles { get; set; }
}