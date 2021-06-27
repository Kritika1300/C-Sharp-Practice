using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"D:\Persnal\C#\C-Sharp-Practice\someFile.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(FileNotFoundException ex) //specific exception
            {
             
                Console.WriteLine("File not found");
                Console.WriteLine(ex.FileName + " not found");
            }  
            catch(Exception ex) //base / general
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
