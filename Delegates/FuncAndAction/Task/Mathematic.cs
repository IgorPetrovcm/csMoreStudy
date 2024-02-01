namespace Task;


public class Mathematic
{
    public List<Formula> formuls = new List<Formula>();

    public int Sum(Func<Formula, int> func)
    {
        int result = 0;

        foreach (Formula fo in formuls)
        {
            result += func(fo);
        }

        return result;
    }

    public int SumA() => Sum(x => x.a);

    public int SumB() => Sum(x => x.b);

    public int SumC() => Sum(x => x.c);
}