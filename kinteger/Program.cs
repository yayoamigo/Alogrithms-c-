using System;
using System.Linq;


namespace kinteger
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            int[] result = new int[k];
            Dictionary<int,int> map = new Dictionary<int,int>();
            foreach (int x in nums)
            {
               if(map.ContainsKey(x)) map[x]++;
               else map[x] = 1;
            }

            var sortedMap = map.OrderByDescending(x => x.Value);
            int i = 0;
            foreach (var x in sortedMap)
            {
                if(i == k) break;
                result[i] = x.Key;
                i++;
            }
           return result;
        }
    }
}