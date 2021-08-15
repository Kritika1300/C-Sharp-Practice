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
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    throw (new MissingFieldException());
                }
                finally
                {
                    Console.WriteLine("Finally");
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw new FieldAccessException();
            }
            finally
            {
                Console.WriteLine("Finally 2");
            }

        }

    }
}