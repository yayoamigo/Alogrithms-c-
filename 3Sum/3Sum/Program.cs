using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //[-1,0,1,2,-1,-4]

        }
    }
    public class Solution
    {
        public List<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            // Sort the array to handle duplicate triplets
            Array.Sort(nums);
            [-4, -1, -1, 0, 1, 2]
        for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicates for i
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Skip duplicates for left and right
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }


}