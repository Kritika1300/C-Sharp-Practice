using System;

namespace Classes
{
    class Customer
    {
  
        public static void Main()
        {
            //int num = int.Parse("abcdd"); this will throw an exception (there are 2 ways to avoid this : 1 use try,catch block 2 using out keyword)

            //use of try-catch

            //try
            //{
            //    int num = int.Parse("abcdd");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Invalid conversion");
            //}

            int result;
            bool answer = int.TryParse("124", out result);

            if(answer)
              Console.WriteLine(result);
            else
                Console.WriteLine("Invalid Conversion");
        }


    }

}
