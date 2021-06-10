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
    public enum Season { 
    Summer,
    Winter,
    Spring
    }


    public static void Main(string[] args)
    {
        Days Funday = (Days)1;
        int a = (int)Days.Monday;
        Days WorkDay = (Days)Season.Summer;
        foreach(string s in Enum.GetNames(typeof(Days)))
        {
            Console.WriteLine(s);
        }
        
    }
}