namespace Lesson1;


public class Program 
{
    static async Task Main()
    {
        byte[] buf1 = {23,55,123,12,33};

        FileStream file = new FileStream("text.txt",FileMode.Create, FileAccess.Write);
        
        file.Write(buf1,0,buf1.Length);

        file.Close();

        byte[] buf2;

        FileStream file2 = new FileStream("text.txt",FileMode.Open, FileAccess.Read);

        buf2 = new byte[file2.Length];

        file2.Read(buf2,0,(int)file2.Length);

        file2.Close();

        for (int i = 0; i < buf2.Length; i++)
        {
            System.Console.WriteLine(buf2[i]);
        }
    }
}