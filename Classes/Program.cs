using System.IO;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\Temp");
            var files = Directory.GetFiles(@"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\Temp", "*.c", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);
        }

    }

}
