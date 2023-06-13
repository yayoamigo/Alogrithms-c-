using System;

namespace BalanceB
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.IsValid("()"));
            Console.WriteLine(sol.IsValid("()[]{}"));
   

        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')   
                {
                    stack.Push(s[i]);

                } else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("stack empty");
                        return false;
                        
                    }
                    if (s[i] == ')' && stack.Peek() != '(')
                    {
                        Console.WriteLine($"dont match {stack.Peek()}");
                        return false;
                    }
                    if (s[i] == ']' && stack.Peek() != '[')
                    {
                        Console.WriteLine($"dont match {stack.Peek()}");
                        return false;
                    }
                    if (s[i] == '}' && stack.Peek() != '{')
                    {
                        Console.WriteLine($"dont match {stack.Peek()}");
                        return false;
                    }
                    stack.Pop();
                }
            } return true;

        }
    }

}