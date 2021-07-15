using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class PartialCustomer
    {
        public void FullName()
        {
            Console.WriteLine(_firstName + " " + _lastName);
        }
    }
}
