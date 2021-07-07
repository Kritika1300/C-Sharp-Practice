using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{

    public class Singleton 
    {
        private static int counter = 0;
        public Singleton()
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
            Singleton fromEmployee = new Singleton();
            fromEmployee.PrintDetails("Employee dets");

            Singleton fromStudent = new Singleton();
            fromStudent.PrintDetails("Student dets");

        }

    }
}

   
