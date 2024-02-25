using System.Reflection;
using System.Runtime.InteropServices;

namespace AssigntoEvent;


public class Program 
{
    static void Main()
    {
        TestClass testClass = new TestClass();

        Console.WriteLine(testClass.PrintOperation(5));
    }
}

public class TestClass
{

    public event Func<double, double> operationEvent;

    public void SetOperation(Func<double, double> func)
    {
        operationEvent = func;
    }

    public void AddOperation(Func<double, double> func)
    {
        operationEvent += func;
    }

    public double PrintOperation(int a)
    {
        if (operationEvent == null)
            return 0;
        return operationEvent.Invoke(a);
    }
}