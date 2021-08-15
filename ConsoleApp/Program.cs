using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace AsyncCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int den = Convert.ToInt32(Console.ReadLine());
                    int res = 100 / den;
                    Console.WriteLine("print");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    //throw (new MissingFieldException());
                }
                finally
                {
                    Console.WriteLine("Finally");
                    throw (new MissingFieldException());

                }
                Console.WriteLine("Ok");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
            finally
            {
                Console.WriteLine("Finally 2");
            }

        }

    }
}