using System.Collections.Generic;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (or type Quit and exit):\n");
            var list = new List<int>();
            var unique = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();

                if(input == "Quit")
                {
                    break;
                }
                else
                {
                    list.Add(Convert.ToInt32(input));
                }
            }

            foreach(var input in list)
            {
                if (!unique.Contains(input))
                {
                    unique.Add(input);
                }
            }

            foreach(var i in unique)
            {
                Console.Write(i + " ");
            }
            




        }
    }

}
