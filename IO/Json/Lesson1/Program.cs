namespace Lesson1;

using System.Net.Http.Headers;
using System.Text.Json;

public class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream( "my.json", FileMode.OpenOrCreate))
        {
            List<string> list = new List<string>()
            {
                "one",
                "two",
                "three",
                "four"
            };

            JsonSerializer.Serialize<List<string>>(fs, list);
        }

        using (FileStream fs = new FileStream( "my.json", FileMode.OpenOrCreate ))
        {
            List<string> list = JsonSerializer.Deserialize<List<string>>(fs);

            foreach (string line in list)
            {
                System.Console.WriteLine(line);
            }
        }
    }
}