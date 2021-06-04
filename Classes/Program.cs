using System.IO;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\someFile.txt";
            File.Copy(@"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\fileSource.txt", @"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\fileDestination.txt", true);
            var content = File.ReadAllText(path);
            Console.WriteLine(content);
        }

    }

}
