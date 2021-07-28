using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Operations Class</summary>
    public class Operations
    {
        ///<summary>Max method</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return (0);
            }
            int max = nums[0];
            foreach (int temp in nums)
            {
                if (temp > max)
                {
                    max = temp;
                }
            }
            return (max);
        }
    }
}
