namespace FirstLesson;


public class Program
{
    static void Main()
    {
        System.Console.WriteLine(TestClass.Operations(1,2,TestClass.Sum));

        TestClass.Actions(1,2,TestClass.SumInConsole);
    }

}

public static class TestClass
{
    static public int Sum(int num, int num2) => num + num2;

    static public int Sub(int num, int num2) => num - num2;

    static public void SumInConsole(int num, int num2) => Console.WriteLine(num + num2); 

    static public int Operations(int num, int num2,Func<int,int, int> operation) => operation(num,num2); 

    static public void Actions(int num, int num2, Action<int, int> action) =>  action(num, num2);
    
}