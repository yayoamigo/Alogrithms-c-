using System;
using System.IO;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Users\david\Desktop\directory\addresses.csv";
            string[] lines = File.ReadAllLines(path);

            List<string> names = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] name = lines[i].Split(',');
                names.Add(name[0]);
            }

            Console.WriteLine(names[1]);
        }
    }
}

