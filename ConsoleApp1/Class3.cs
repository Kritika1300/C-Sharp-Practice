using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName 
        {
            get { return _firstName; }
            set { this._firstName = value; } 
        }
        public string LastName
        {
            get { return _lastName; }
            set { this._lastName = value; }
        }

        public partial void FullName();
        public partial void FullName()
        {
            Console.WriteLine(_firstName + " " + _lastName);
        }

    }
}
