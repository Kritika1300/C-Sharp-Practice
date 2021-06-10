using System;
class Test
{
    public enum Days { 
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
    }

    public static void Main(string[] args)
    {
        foreach(int i in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(i);
        }
        foreach(string s in Enum.GetNames(typeof(Days)))
        {
            Console.WriteLine(s);
        }
        
    }
}