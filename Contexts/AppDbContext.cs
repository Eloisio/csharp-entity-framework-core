using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=Localhost;Database=EFCoreExample;Trusted_Connection=True;");
    }
}