using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
class Program
{

    public static void Main(string[] args)
    {

        //array to string
        string str = new string("HELOOOOOO");
        int[] arr = { 1, 2, 3, 3 };
        string s = string.Join(",",1233333,str,"pppppppppppppppppp"); //Method 1
        string s1 = string.Join("",arr); //Method 2

        char[] arr1 = { 'p', 'y' };
        string s2 = new string(arr1); // Only for char array
        Console.WriteLine(s);

        string s3 = "Kritika";
        char[] arr2 = s3.ToCharArray();
        Console.WriteLine(arr2);



    } 
}