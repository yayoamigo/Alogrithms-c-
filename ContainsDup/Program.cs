using System;

namespace ContainsDup
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    return true;
                } else
                {
                    dic.Add(num, num);
                }
            } return false;
        }
    }
}