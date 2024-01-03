using Microsoft.EntityFrameworkCore;

namespace CRUD_Operation;


public class Context : DbContext
{
    public DbSet<User> Users {get; set;}

    public Context() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder contextBuilder)
    {
        contextBuilder.UseSqlite("Data Source=my.db");
    }
}