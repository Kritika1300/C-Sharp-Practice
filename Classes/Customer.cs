using System;

namespace Classes
{
    class Customer
    {
        //public int Add(int[] numbers)
        //{
        //    int sum = 0;
        //    foreach(var i in numbers)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}
        //public static void Main()
        //{
        //    Customer c = new Customer();
        //    Console.WriteLine(c.Add(new int[3] { 1, 2, 3 })); 

        //}

        //All of this can be avoided using params keyword

        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var i in numbers)
            {
                sum += i;
            }
            return sum;
        }
        public static void Main()
        {
            Customer c = new Customer();
            Console.WriteLine(c.Add( 1, 2, 3, 4, 5 ));

        }


    }

}
