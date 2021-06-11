using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
class Program
{
    
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().ToLower().Split(" ");
        for (int i = 0; i < input.Length; i++)
        {
            var newword = input[i].Substring(0,1).ToUpper() + input[i].Substring(1);
            input[i] = newword;

        }
        var newString = "";
        foreach (var word in input)
        {
            newString += word;
        }
        Console.WriteLine(newString);
    }
}