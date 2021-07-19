using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //public class DataAccessLayer 
    //{
    //    public void GetCustomerNameDAL()
    //    {
    //        Console.WriteLine("Name");
    //    }
    //}
    //public class BusinessLayer
    //{
    //    public void GetCustomerNameBL()
    //    {
    //        DataAccessLayer obj = new DataAccessLayer(); Higher level module dependent on Lower Level module
    //        obj.GetCustomerNameDAL();

    //    }
    //}
    public class DataAccessLayer : IGetCustomerName
    {
        public void GetCustomerNameDAL()
        {
            Console.WriteLine("Name");
        }
    }

    public interface IGetCustomerName 
    {
        public void GetCustomerNameDAL();
        
    }

    public class BusinessLayer
    {
        public void GetCustomerNameBL()
        {
            IGetCustomerName obj = new DataAccessLayer();
            obj.GetCustomerNameDAL();

        }
    }
    public class HelloWorld
    {
        public static void Main()
        {
            BusinessLayer b = new BusinessLayer();
            b.GetCustomerNameBL();

        }

    }

}







