using System.ComponentModel;

namespace Test;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class TestAttribute : Attribute
{
    public TestAttribute() {}

    public void OnEntry()
    {
        System.Console.WriteLine("Method start");
    }

    public void OnExit()
    {
        System.Console.WriteLine("Method end");
    }
}