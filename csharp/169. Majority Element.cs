/**
 * Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
 * 
 * You may assume that the array is non-empty and the majority element always exist in the array.
 */
 
public class Solution {
    public int MajorityElement(int[] nums) {
            int majority = 0, counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (counter == 0)
                {
                    majority = nums[i];
                    counter = 1;
                }
                else if (majority == nums[i])
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            return majority;
    }
}