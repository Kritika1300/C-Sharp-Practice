using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        public static void Main()
        {


            DateTime? date = null;

            DateTime date1; // to convert Nullable value to DateTime 

            date1 = date ?? DateTime.Today;

            Console.WriteLine(date1);


        }
    }

    

}




