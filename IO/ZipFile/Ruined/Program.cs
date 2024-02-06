namespace Ruined;

using System.IO.Compression;

public class Program 
{
    static void Main()
    {
        //Разорхивация
        ZipFile.ExtractToDirectory("48.zip","extract/");

        //Архивация
        ZipFile.CreateFromDirectory("extract","newZip.zip");
    }
}