using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
class Person
{
    public string fname;

    public void Introduce(string name)
    {
        Console.WriteLine("Hi {0}, I am {1}",fname,name);
    }

    public static Person Parse(string s)
    {
        var person = new Person();
        person.fname = s;

        return person;
    } 
    public static void Main(string[] args)
    {
        var p = Person.Parse("Krika");
        p.Introduce("Lolo");

    } 
}