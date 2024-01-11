namespace ManageDbProgram;

using System.Dynamic;
using Microsoft.EntityFrameworkCore;


public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb_test;Username=postgres;Password=jd4lok");
    }
}