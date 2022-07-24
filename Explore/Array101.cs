using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore
{
    public class Array101
    {
        public void Run()
        {
            //1. Max Consecutive Ones
            int[] nums1 = {0, 0, 1, 1, 0, 0};
            int result1 = FindMaxConsecutiveOnes(nums1);
            Console.WriteLine(result1);

            //2. Find Numbers with Even Number of Digits
            int[] nums2 = { 12, 345, 2, 6, 7896 };
            int result2 = FindNumbers(nums2);
            Console.WriteLine(result2);

            //3. Squares of a Sorted Array
            int[] nums3 = {-4,-1,0,3,10};
            int[] result3 = SortedSquares(nums3);
            Console.WriteLine('[' + string.Join(", ", result3) + ']');
        }

        /// <summary>
        /// Squares of a Sorted Array
        /// Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }
            Array.Sort(result);
            return result;
        }

        /// <summary>
        /// Find Numbers with Even Number of Digits
        /// Given an array nums of integers, return how many of them contain an even number of digits.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach (var num in nums)
            {
                int digits = 1;
                int temp = num;
                while (temp/10 > 0)
                {
                    temp = temp/10;
                    digits++;
                }
                if (digits % 2 == 0)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Max Consecutive Ones
        /// Given a binary array nums, return the maximum number of consecutive 1's in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;
            foreach (var num in nums)
            {
                count = num == 0 ?  0 : count + 1;
                if (max < count) max = count;
            }
            return max;
        }

    }
}
