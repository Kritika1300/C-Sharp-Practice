using System;
class Test
{
    public struct Customer {

        private string _fname;
        private string _lname;
        
        public string _Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public string _Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }
        public Customer(string fname, string lname)
        {
            _fname = fname;
            _lname = lname;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{_fname} {_lname}");
        }

    }
    public static void Main(string[] args)
    {
        Customer c1 = new Customer("A", "B");
        c1.PrintDetails();
        Customer c2 = new Customer();
        c2._Fname = "C";
        c2._Lname = "D";
        c2.PrintDetails();
        Customer c3 = new Customer
        {
            _Fname = "E",
            _Lname = "G"
        };
        c3.PrintDetails();


    }
}