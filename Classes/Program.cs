using System.IO;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\Classes\Classes.sln";
            var extension = Path.GetExtension(path);
            Console.WriteLine(extension);
            var filename = Path.GetFileName(path);
            Console.WriteLine(filename);
            var file = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine(file);
            var dir = Path.GetDirectoryName(path);
            Console.WriteLine(dir);
        }

    }

}
