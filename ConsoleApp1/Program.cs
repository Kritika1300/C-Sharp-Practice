using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"D:\Persnal\C#\C-Sharp-Practice\ile.txt");
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
            finally // to release resources held by the class finallly block is used,
                    // finally block is reqd because an exception may even occur in one the catch blocks
                    // therefore any statements after that wouldn't be executed, so it's always better to realease resources using FINALLY (as it is guaranteed to execute)
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
           
                Console.WriteLine("Entered finally block");
            }
        }
    }
}
