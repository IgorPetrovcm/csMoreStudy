using System.Reflection;
using System.Runtime.InteropServices;

namespace AssigntoEvent;


public class Program 
{
    static void Main()
    {
        TestClass testClass = new TestClass();

        testClass.operationEvent += (x) => x + x;

        testClass.operationEvent += (x) => x * x;

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
        return operationEvent.Invoke(a);
    }
}