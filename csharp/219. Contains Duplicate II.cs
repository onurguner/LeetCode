
/*
Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array 
such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
*/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums == null && nums.Length == 0) {
            return false;
        }
        
        Dictionary<int, int> table = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++) {
            if (table.ContainsKey(nums[i])) {
                if (Math.Abs(table[nums[i]] - i) <= k) {
                    return true;
                } else {
                    table[nums[i]] = i;
                }
            } else {
                table.Add(nums[i], i);
            }
        }
        
        return false;
    }
}