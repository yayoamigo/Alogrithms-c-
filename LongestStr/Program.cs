using System;
using System.Text;

namespace RomantoInt
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(new Solution().LengthOfLongestSubstring("abba"));
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            int begin = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    begin = Math.Max(begin, map[s[i]] + 1);
                    map[s[i]] = i;
                }
                else
                {
                    map.Add(s[i], i);
                }
                Console.WriteLine($"{i} is the end");
                Console.WriteLine($"{begin} is the begining");
                Console.WriteLine($"the max until now is {max}");
                Console.WriteLine("the operation is {0}", i - begin + 1);
                max = Math.Max(max, i - begin + 1);
            }

            return max;


        }
    }


}

