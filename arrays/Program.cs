using System;
using System.Net.Security;

class Program
{

    static void Main(string[] args)
    {
        Object[] random = {"hello", 1, true, false};
       
        foreach(object item in random)
        {
            Console.WriteLine(item);
        }

    }

}

