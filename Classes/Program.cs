using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
          

            DateTime? date = new DateTime(2000,1,11);

            DateTime date1; // to convert Nullable value to DateTime 

            if(date == null)
            {
                date1 = date.GetValueOrDefault();
            }
            else
            {
                date1 = DateTime.Today;
            }

            Console.WriteLine(date1);


        }
    }

    

}




