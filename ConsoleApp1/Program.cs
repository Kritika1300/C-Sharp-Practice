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
                try
                {
                    Console.WriteLine("Enter first number");
                    int fn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int sn = Convert.ToInt32(Console.ReadLine());
                    int result = fn / sn;
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    string path = @"D:\Persnal\C#\C-Sharp-Practice\lo.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write(ex.GetType().Name);
                        sw.Close();
                        Console.WriteLine("Some error occured");

                    }
                    else
                    {
                        throw new FileNotFoundException("File not found", ex);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Current exception = " + e.GetType().Name);
                Console.WriteLine("Inner Exception = " + e.InnerException.GetType().Name);
            }
            
        }
    }
}
