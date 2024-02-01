namespace Task;


public class Program 
{
    static void Main()
    {
        Mathematic math = new Mathematic();
        math.formuls = new List<Formula>(){
            new Formula(1,2,3),
            new Formula(1,2,3),
            new Formula(1,2,3),
            new Formula(1,2,3),
            new Formula(1,2,3),
            new Formula(1,2,3)
        };

        System.Console.WriteLine(math.SumB());
    }
}