using System;

namespace RegexDynamic
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        int n, m;
        Dictionary<string, bool>? cache;

        public bool IsMatch(string s, string p)
        {
            n = s.Length;
            m = p.Length;
            cache = new Dictionary<string, bool>();
            return topDown(0, 0, s, p);
        }

        public bool topDown(int i, int j, string s, string p)
        {
            if (i >= n && j >= n)
            {
                return true;
            }
            else if (j >= m)
            {
                return false;
            }

            string key = i + "-" + j;
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }

            bool charsMatch = i < n && (s[i] == p[j] || p[j] == '.');

            bool isMatch;

            if (j < m - 1 && p[j + 1] == '*')
            {
                isMatch = ((charsMatch && topDown(i + 1, j, s, p)) ||
                      topDown(i, j + 2, s, p));
            }
            else
            {
                isMatch = charsMatch && topDown(i + 1, j + 1, s, p);
            }

            cache[key] = isMatch;
            return isMatch;
        }
    }

}