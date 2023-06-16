using System;
using System.Text;

namespace LongestPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] strs = new string[] { "flower", "ow", "flight" };
            Console.WriteLine(s.LongestCommonPrefix(strs));

        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            Array.Sort(strs);
            int length = strs[0].Length;
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != currentChar)
                        return ans.ToString();
                }

                ans.Append(currentChar);
            }

            return ans.ToString();
        }

    }
}