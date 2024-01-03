namespace CRUD_Operation;

using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;


class Program 
{
    
    static void Main()
    {
        //Добавление
        using (Context context = new Context())
        {
            System.Console.WriteLine("Input name created user: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Input age created user: ");
            int age = Convert.ToInt32(Console.ReadLine());

            context.Users.Add(new User{Name = name, Age = age});

            context.SaveChanges();

            if (context.Users.Count() < 2)
                return;
        }

        //Редактирование
        using (Context context = new Context())
        {
            System.Console.Clear();
            System.Console.WriteLine("Update user");

            foreach (User user in context.Users)
                System.Console.WriteLine(user.Id + " " + user.Name + " " + user.Age);

            System.Console.WriteLine("Input id user: ");
            int id = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Input new name updated user: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Input new age updated user: ");
            int age = Convert.ToInt32(Console.ReadLine());

            User updateUser = context.Users.First(x => x.Id == id);

            updateUser.Name = name;
            updateUser.Age = age;

            context.Users.Update(updateUser);

            context.SaveChanges();
        }

        //Удаление
        using (Context context = new Context())
        {
            Console.Clear();

            foreach (User user in context.Users)
                System.Console.WriteLine(user.Id + " " + user.Name + " " + user.Age);
            
            System.Console.WriteLine("Input id user want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            context.Users.Remove(context.Users.First(x => x.Id == id));

            context.SaveChanges();

            foreach (User user in context.Users)
            {
                System.Console.WriteLine(user.Id + " " + user.Name + " " + user.Age);
            }
        }
    }
}