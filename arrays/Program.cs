using System;
using System.Globalization;
using System.Net.Security;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("this is a string");
        StringBuilder sb2 = new StringBuilder("another string", 256);
        Console.WriteLine("Capacity : {0}", sb2.Capacity);
        Console.WriteLine("Lenght: {0}", sb2.Length);
        sb2.AppendLine("\nMore stuff");
        CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
        string bestCust = "Bob Smith";
        sb2.AppendFormat(enUs,"Best Customer : {0}", bestCust);

    }

}

