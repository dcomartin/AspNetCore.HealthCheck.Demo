using Microsoft.EntityFrameworkCore;

namespace AspNetCore.HealthCheck.Demo
{
    public class MyDbContext : DbContext
    {        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=:memory:;");
        }
    }
}