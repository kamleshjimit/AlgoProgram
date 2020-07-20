using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MySorting
{
    public static class Numbers
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            Hashtable ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if(! dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
                ht.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(ht.ContainsKey(complement))
                {
                    int v = (int)ht[complement];
                
                    if (v != i)
                        return new int[] { i, v };
                }
                //if (dict.ContainsKey(complement))
                //{
                //    int v;
                //    dict.TryGetValue(complement, out v);
                //    if (v != i)
                //        return new int[] { i, v };
                //}

            }

            return null;

        }

    }
}
