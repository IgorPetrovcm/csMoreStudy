using System.Text;

namespace ConvertNewEncoding;


public class Program 
{
    static void Main()
    {
        Encoding utf8 = Encoding.UTF8;
        Encoding ascii = Encoding.ASCII;

        string sourceText = "PIOKJ@(лвоавл)(*]+\\||/)ау";

        byte[] utf8Bytes = Encoding.UTF8.GetBytes(sourceText);
        byte[] asciiBytes = Encoding.Convert(utf8,ascii,utf8Bytes);

        char[] asciiChar = new char[ascii.GetCharCount(asciiBytes)];
        ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChar, 0);
        string asciiString = new string(asciiChar);

        System.Console.WriteLine(asciiString);
    }
}