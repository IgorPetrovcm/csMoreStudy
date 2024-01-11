namespace ManageDbProgram;

using Microsoft.EntityFrameworkCore;


public class Program
{
    static void Main()
    {
        using (ApplicationContext context = new ApplicationContext())
        {
            foreach (User user in context.Users.ToList<User>())
            {
                System.Console.WriteLine(user.Name);
            }
        }

    }
}