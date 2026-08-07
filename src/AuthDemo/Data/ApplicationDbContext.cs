using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Data;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : IdentityDbContext(options)
{
}