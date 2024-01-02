namespace ConnectingToExistDB;
using Microsoft.EntityFrameworkCore;


public class Program
{
    static void Main()
    {
        System.Console.WriteLine("Input your name: ");
        string name = Console.ReadLine();

        System.Console.WriteLine("Input your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        using (Context context = new Context())
        {
            context.Users.Add(new User{Name = name, Age = age});

            context.SaveChanges();

            foreach (User user in context.Users.ToList())
            {
                System.Console.WriteLine(user.Name + " " + user.Age);
            }
        }
    }
}