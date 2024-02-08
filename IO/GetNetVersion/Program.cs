namespace GetNetVersion;

public class GetNetVersion
{
    static void Main()
    {
        char v = Environment.Version.ToString()[0];

        System.Console.WriteLine( v );
    }
}