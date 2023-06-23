using System;

namespace MaxWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Solution solution = new Solution();
            Console.Write(solution.MaxArea(arr));
        }
        public class Solution
        {
            public int MaxArea(int[] height)
            {
                int i = 0;
                int j = height.Length - 1;
                int max = 0;
                int iHeight;
                int jHeight;
                int temp;

                while (j > i)
                {
                    iHeight = height[i];
                    jHeight = height[j];


                    if (iHeight > jHeight)
                    {
                        temp = jHeight * (j - i);
                        j--;
                    }
                    else
                    {
                        temp = iHeight * (j - i);
                        i++;
                    }

                    if (temp > max)
                        max = temp;

                }
                return max;
            }
        }
    }
}
