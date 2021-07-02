using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{


  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-13.php
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(2);
            myList.Add(3);
            myList.Add(1);
            myList.Add(4);
            myList.Add(7);
            myList.Add(5);

            IEnumerable<int> ienum = myList;

            foreach(int i in ienum)
                Console.WriteLine(i);

            IEnumerator<int> enumerator = myList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }



        }

    }
}

   
