namespace Data;

using Microsoft.EntityFrameworkCore;
using Entities;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options)
    {}

    public DbSet<Company> Companies => Set<Company>();

    public DbSet<User> Users => Set<User>();
}