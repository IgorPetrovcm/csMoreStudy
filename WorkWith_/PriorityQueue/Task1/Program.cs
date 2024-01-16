namespace Task1;


public class Program
{
    static void Main()
    {
        PriorityQueue<int,int> queue = new PriorityQueue<int, int>();

        queue.Enqueue(1,1);
        queue.Enqueue(2,2);
        queue.Enqueue(3,3);
        queue.Enqueue(4,4);
        queue.Enqueue(5,5);
        queue.Enqueue(6,6);

        //Удаляем низший по приоритету элемент
        System.Console.WriteLine(queue.Dequeue());

        //Возвращаем низший по приоритету элемент
        System.Console.WriteLine(queue.Peek());

        
    }
}