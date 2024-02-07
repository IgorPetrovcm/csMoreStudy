namespace Regex_Groups;

using System.Text.RegularExpressions;

public class Program 
{
    static void Main()
    {
        string line = Console.ReadLine();

        Regex regex = new Regex(@"\(([a-zA-Z0-9\-_]+)\)");

        Match match = regex.Match(line);

        System.Console.WriteLine(match.Groups[1]);
    }
}