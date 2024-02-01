using System.Security.Cryptography.X509Certificates;

namespace FirstLesson;


public class Program
{
    static void Main()
    {
        var operation = (int a, int b) => Console.WriteLine(a + b);

        operation(1,2);
        
        Message mes = b => System.Console.WriteLine(b * b); 

        mes(2);


        string line = "texttext";

        System.Console.WriteLine(NewText(line, x => line.Replace("tx","")));
    }
    static string NewText(string line, Remove remove)
    {
        string old = remove(line);
        return old += "HELLO";
    }

    public delegate void Message(int b);

    public delegate string Remove(string removeParam); 

}