using System;
using System.Collections.Generic;

namespace Classes
{
    class Customer {

        private DateTime _birthdate;

        public void SetBirthDate(DateTime _birthdate)
        {
            this._birthdate = _birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
        public static void Main()
        {
            Customer c = new Customer();
            c.SetBirthDate(new DateTime(2000, 1, 11));
            Console.WriteLine(c.GetBirthDate());


        }



    }
}
