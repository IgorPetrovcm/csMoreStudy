namespace FormalizedTemplate;


public class Program
{
    static void Main()
    {

    }
}

public class MyClass : IDisposable
{
    private bool disposed = false;

    //Реализация IDisposable
    public void Dispose()
    {
        //Освободить не управляемые ресурсы 
        Dispose(true);

        //Блокируем вызов Finalize
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
        {
            //Осовобождение управляемых ресурсов
        }
        //освобождение неуправляемых ресурсов 
        disposed = true;
    }

    //Деструктор
    ~MyClass()
    {
        Dispose(false);
    }
}