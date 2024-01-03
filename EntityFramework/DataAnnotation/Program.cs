namespace DataAnnotation;
using Microsoft.EntityFrameworkCore;


public class Program
{
    static void Main()
    {
        using (Context context = new Context())
        {
            context.Users.Add(new User{Name = "random", Age = 12, Company = new Company(){Name = "Microsoft"}, Country = new Country() {Name = "USA"} });

            context.SaveChanges();

            foreach (Country country in context.Countries)
                System.Console.WriteLine(country.Name);
        }

    }
}