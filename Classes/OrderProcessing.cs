

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    class BankAccount 
    {
        private  int _accountNumber;

        private double _balance;

        private string _accountHolderName;

        private string _password;

        public int AccountNumber { get { return _accountNumber; } }

        public string AccountHolderName{ get { return _accountHolderName; } }

        public BankAccount(int anumber, string aholder, string password)
        {
            this._accountNumber = anumber;
            this._accountHolderName = aholder;
            this._password = password;
            this._balance = 0;

        }
        
      
        public double GetBalance(string aholder, string password)
        {
            if(aholder == this._accountHolderName && password == _password)
            {
                return _balance;
            }
            else
            {
                Console.WriteLine("Invalid credentials");
                return 0;
            }
        }

        public void AddBalance(string aholder, string password, double addbalance)
        {
            if (aholder == this._accountHolderName && password == _password)
            {
                _balance += addbalance;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount(234,"Kritika", "#abc");
            Console.WriteLine(b.AccountHolderName);
            Console.WriteLine(b.AccountNumber);
            Console.WriteLine(b.GetBalance("Kritika", "#abc"));
            b.AddBalance("Kritika", "#abc", 3232423);
            Console.WriteLine(b.GetBalance("Kritika", "#abc"));
       
     

        }
    }

}