namespace Lesson2;


public class Program
{
    static void Main()
    {
        System.Console.WriteLine(YourOperation("hell",x => x + x));
    }

    public static string YourOperation(string line, Func<string, string> func)
    {
        return func(line);
    }
}