/**
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * 
 * Example:
 * Given nums = [2, 7, 11, 15], target = 9,
 * 
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 */
 
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        if (nums == null || nums.Length == 0)
            return null;
            
        Dictionary<int, int> table = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++)
        {
            int find = target - nums[i];
            if (table.ContainsKey(find))
            {
                result[0] = table[find];
                result[1] = i;
                return result;
            }
            
            if (table.ContainsKey(nums[i]))
                table[nums[i]] = i;
            else
                table.Add(nums[i], i);
        }
        return result;
    }
}