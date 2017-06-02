/*
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
*/

public class Solution {
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        if (nums.Length == 1) {
            return nums[0];
        }
        
        int[] money = new int[nums.Length];
        money[0] = nums[0];
        money[1] = nums[0] > nums[1] ? nums[0] : nums[1];
        
        for (int i=2; i<nums.Length; i++) {
            money[i] = Math.Max(nums[i] + money[i-2], money[i-1]);
        }
        
        return money[nums.Length - 1];
    }
}