using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            //DateTime date = null; value types can't be assigned null value

            Nullable<DateTime> date = null;  //Nullable type or DateTime? date = null
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value); will throw Exception as value is NULL in this case

            DateTime date1 = date.GetValueOrDefault();

            DateTime? date3 = date1;


        }
    }

    

}




