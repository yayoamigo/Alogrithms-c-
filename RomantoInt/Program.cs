using System;

namespace RomantoInt
{
    class Program
    {
        public static void Main(string[] args)
        {
           int print = new Solution().RomanToInt("MCMXCIV");
           Console.WriteLine(print);

        }
        }
        public class Solution
        {
            public static Dictionary<string, int> romanNumerals = new Dictionary<string, int>()
    {
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 }
    };

            private int result;

            public int Result
            {
                get { return result; }
                set { result = value; }
            }

            public int RomanToInt(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i < s.Length - 1 && romanNumerals[s[i].ToString()] < romanNumerals[s[i + 1].ToString()])
                    {
                        Result -= romanNumerals[s[i].ToString()];
                    }
                    else
                    {
                        Result += romanNumerals[s[i].ToString()];
                    }
                }

                return Result;
            }
        }

    }

