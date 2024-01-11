namespace ConnectionConfigurations ;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


public class Program
{
    static void Main()
    {
        ConfigurationBuilder configBuilder = new ConfigurationBuilder();

        configBuilder.SetBasePath(Directory.GetCurrentDirectory());
        configBuilder.AddJsonFile("appsettings.json");

        IConfigurationRoot config = configBuilder.Build();

        DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
        optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));

        DbContextOptions options = optionsBuilder.Options;

        using (ApplicationContext context = new ApplicationContext(options))
        {
            context.Users.Add(new User {Name = "Igor"});

            context.SaveChanges();

            System.Console.WriteLine(context.Users.Find(1).Name);
        }
    }
}