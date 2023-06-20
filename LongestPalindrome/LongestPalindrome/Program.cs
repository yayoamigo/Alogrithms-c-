﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LongestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {


        public string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1)
            {
                return "";
            };
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = Expandin(s, i, i);
                int len2 = Expandin(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - ((len - 1) / 2);
                    end = i + (len / 2);
                }
            }

            return s.Substring(start, end - start + 1);


            int Expandin(string s, int left, int right)
            {
                if (s == null || left > right)
                {
                    return 0;
                }
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;

                }
                return right - left - 1;
            }
        }
    }
}