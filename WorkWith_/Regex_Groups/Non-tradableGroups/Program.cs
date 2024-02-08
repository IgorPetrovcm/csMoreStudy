namespace Non_tradableGroups;

using System.Text.RegularExpressions;

public class Program
{
    static void Main()
    {
        string input1 = "add polygon";
        string input2 = "add point";
        string input3 = "end polygon";

        Regex regex = new Regex("^(?:add polygon|add point|end polygon)");

        Match match = regex.Match(input1);

        System.Console.WriteLine(match.Groups[0].Value);

        match = regex.Match(input2);

        System.Console.WriteLine(match.Groups[0].Value);

        match = regex.Match(input3);

        System.Console.WriteLine(match.Groups[0].Value);

        /*
            Output:
            add polygon
            add point
            end polygon
        */
    }
}