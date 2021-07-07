using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{

    public class Singleton 
    {
        private static int counter = 0;
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton(); 
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
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("Employee dets");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Student dets");

        }

    }
}

   
