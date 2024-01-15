namespace Pointers_Unsafe;


public class Pointers
{
    static void Main()
    {
        unsafe{
            /*int* a;

            int y = 20;

            a = &y;

            System.Console.WriteLine(*a);

            y = 50;

            System.Console.WriteLine(*a);

            *a = 30;

            System.Console.WriteLine(y);*/

            Data data = new Data(5,10);

            Data* pointToData = &data;

            //Мф не можем на прямую обратиться к полям структуры, так как pintToData это лишь указатель на структуру, поэтому используем конструкцию '->'
            pointToData->X = 20;

            System.Console.WriteLine(*pointToData);

            System.Console.WriteLine(pointToData -> X);

            //Также есть альтернатива '->' 
            (*pointToData).Y = 100;

            System.Console.WriteLine((*pointToData).Y);

        }
    }
    struct Data
    {
        public int X {get;set;}

        public int Y {get;set;}

        public Data(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} - {Y}";
        }
    }
}