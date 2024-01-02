namespace FirstTask;


public class Program
{
    static void Main()
    {
        using (ApplicationContext context = new ApplicationContext())
        {
            User user1 = new User() {Name = "vlad1", Age = 22};
            User user2 = new User() {Age = 12};

            context.Users.Add(user1);
            context.Users.Add(user2);

            context.SaveChanges();

            foreach (User user in context.Users.ToList())
            {
                System.Console.WriteLine(user.Id + " " + user.Name + " " + user.Age);
            }
        }
    }
}