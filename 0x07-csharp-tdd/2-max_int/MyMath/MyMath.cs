using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> A class called Operations holding Max method </summary>
    public class Operations
    {
        /// <summary> A method called Max that finds the max integer </summary>
        /// <param name="nums"> The list of numbers </param>
        /// <returns> Max integer in list </returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return (0);
            int max = nums[0];
            foreach (int index in nums)
            {
                if (index > max)
                    max = index;
            }
            return max;
        }
    }
}
