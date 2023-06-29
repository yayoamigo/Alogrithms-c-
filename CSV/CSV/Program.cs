using System;
using System.IO;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream filestream = new FileStream(@"C:\Users\david\Desktop\directory\addresses.csv", FileMode.Open);
            using(var reader = new StreamReader(filestream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var cells = line.Split(',').ToList();
                    if (RowHasData(cells))
                    {
                        foreach (var cell in cells)
                        {
                            Console.WriteLine(cell);
                        }
                    }
                }
            }

            static bool RowHasData(List<string> cells)
            {
                return cells.Any(x => x.Length > 0);
            }
        }
    }
}

