using Microsoft.EntityFrameworkCore;

namespace ConnectingToExistDB;


public class Context : DbContext
{
    public DbSet<User> Users {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder context)
    {
        context.UseSqlite("Data Source=../FirstTask/helloapp.db");
    }
}