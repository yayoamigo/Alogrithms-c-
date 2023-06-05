using System;
using System.Net.Security;

class Program
{

    static void Main(string[] args)
    {
        string name1 = "John";
        string name2 = "John";
        if (name1.Equals(name2))
        {
            Console.WriteLine("true");
        } else
        {
            Console.WriteLine("false");
        }

    }

}

