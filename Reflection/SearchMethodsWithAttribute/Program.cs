using System.Reflection;

namespace Test;


public class Program
{
    static void Main()
    {
        Type type = typeof(Entity);

        IEnumerable<MethodInfo> methods = type.GetMethods().Where(x => x.GetCustomAttributes(typeof(TestAttribute),false).Length > 0);

        foreach (MethodInfo method in methods )
        {
            System.Console.WriteLine(method.Name);
        }
    }
}