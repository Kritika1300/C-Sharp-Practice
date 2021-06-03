using System;
namespace Classes
{
  
    public class Person1{

        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Increment(num);
            Console.WriteLine(num);

            var per = new Person1() { age = 21 };
            AgeIncrement(per);
            Console.WriteLine(per.age);
        }
             public static void Increment(int num)
            {
                num += 10;
            }

            public static void AgeIncrement(Person1 per)
            {
                per.age += 20;
            }
        }
}
