namespace ConnectionConfigurations;

using Microsoft.EntityFrameworkCore;


public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public ApplicationContext(DbContextOptions options) : base(options)
    {
        Database.EnsureDeleted();

        Database.EnsureCreated();
    }
}