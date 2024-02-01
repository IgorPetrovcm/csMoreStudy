namespace Task;


public class Program
{
    static void Main()
    {
        IEnumerable<string> inputs = GetUsersInput();

        foreach (string line in inputs)
        {
            System.Console.WriteLine("Вы ввели: " + line);
        }
    }
    static IEnumerable<string> GetUsersInput()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input == null || input.Trim().Length == 0)
                yield break;
            
            if (input == "exit")
                break;

            yield return input;
        }
    }
}

public static class UserInputForm
{

}