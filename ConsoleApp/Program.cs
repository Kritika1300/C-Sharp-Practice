using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO; 

namespace ConsoleApp1
{


    class Test
    {
        static void Main(string[] args)
        {
            ExceptionHandling e = new ExceptionHandling();
            e.Divide(6, 0);
        }

    }
    class ExceptionHandling
    {
     
        public void Divide(int num, int den)
        {
          try
            {
                try
                {
                    int res = num / den;
                }
                catch (Exception e)
                {
                    string path = @"D:\Persnal\C#\C-Sharp-Practice\ConsoleApp\Test.txt";
                    if (File.Exists(path))
                    {
                        Console.WriteLine(e.Message);
                        using (var sw = new StreamWriter(path))
                        {
                            sw.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException("File not found ", e);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Inner exception: " + ex.InnerException.GetType().Name );
                Console.WriteLine("Current exception: " + ex.GetType().Name);

            }

        }

    }
    
   
}





