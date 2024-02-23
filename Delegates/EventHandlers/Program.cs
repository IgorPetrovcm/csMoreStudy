using System.Diagnostics.Contracts;

namespace EventHandlers;


public class Program
{
    static void Main()
    {
        Counter counter = new Counter(1);

        counter.ThresholdReached += EventMethodThersholdReached;

        counter.Add(2);
    }

    static void EventMethodThersholdReached(object? sender, EventArgs e)
    {
        Counter? counter = sender as Counter;

        if (counter is not null)
        {
            System.Console.WriteLine(counter.Total);
        }
    }
}

public class Counter
{
    private readonly int threshold;

    private int total;

    public int Total => total;

    public Counter(int threshold)
    {
        this.threshold = threshold ;
    }

    public void Add(int x)
    {
        total += x;

        if (total >= threshold)
        {
            ThresholdReached?.Invoke(this, EventArgs.Empty);
        }
    }

    public event EventHandler ThresholdReached;
}