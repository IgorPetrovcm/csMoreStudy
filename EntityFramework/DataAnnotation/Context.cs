namespace DataAnnotation;
using Microsoft.EntityFrameworkCore;


public class Context : DbContext
{
    public DbSet<User> Users {get; set;}

    public DbSet<Country> Countries {get;set;}

    public Context()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=helloapp.db");
    }
}