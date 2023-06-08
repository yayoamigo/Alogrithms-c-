using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{

    static void Main(string[] args)
    {

        List<int> list = new List<int> { 1,2,3};
        string joinedString = string.Join("", list);
        Console.WriteLine(joinedString);

    }
}

