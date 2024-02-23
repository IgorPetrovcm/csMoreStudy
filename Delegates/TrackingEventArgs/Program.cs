namespace TrackingEventArgs;


public class Program 
{
    static void Main()
    {
        TestClass testClass = new TestClass();

        testClass.ev += AEventHandler;

        testClass.Run();

        System.Console.WriteLine(testClass.test.answer);
    }

    static void AEventHandler(object? sender, EventArgs e)
    {
        TestEventArgs te = e as TestEventArgs;
        
        te.answer = true;
    }
}

public class TestClass
{
    public event EventHandler ev;

    public TestEventArgs test = new TestEventArgs();

    public void Run()
    {
        ev.Invoke(null, test);
    }
}

public class TestEventArgs : EventArgs
{
    public bool answer = false;
} 