using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Classes
{

    public sealed class Singleton 
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static object obj = new object();

        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                       
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Instance number:" + counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Parallel.Invoke(
                () => EmployeeDetails(),
                () => StudenDetails()
            );

        }

        private static void StudenDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Student dets");
        }

        private static void EmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("Employee dets");
        }
    }
}

   
