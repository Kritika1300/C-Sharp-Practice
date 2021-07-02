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
            LessThanthree(myList);
     

             void LessThanthree(IEnumerable<int> ienum)
            {
                foreach (int i in ienum)
                {
                    Console.WriteLine(i + "func1 ");
                    if (i > 3)
                       MoreThanthree(ienum);

                }

            }

             void MoreThanthree(IEnumerable<int> ienum)
            {
                foreach (int i in ienum)
                {
                    Console.WriteLine(i + "func2 ");

                }


            }



            //IEnumerator<int> enumerator = myList.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.ToString());
            //}



        }

    }
}

   
