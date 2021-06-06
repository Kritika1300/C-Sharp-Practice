using System.Linq;
using System;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>();
          
            while(number.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                var currNumberIndex = number.IndexOf(input);
                if (currNumberIndex >= 0)
                {
                    Console.WriteLine("Number already exists");
                }
                else
                {
                    number.Add(input);
                }

            }
              
            number.Sort();
            foreach(var j in number)
               Console.Write(j + " ");
            
        }
      

    }

}
