
/*
Given an array and a value, remove all instances of that value in place and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.

Example:
Given input array nums = [3,2,2,3], val = 3

Your function should return length = 2, with the first two elements of nums being 2.
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        int start = 0, end = nums.Length - 1;
        while (start <= end) {
            if (nums[start] == val) {
                nums[start] = nums[end];
                nums[end--] = val;
            } else {
                start++;
            }
        }
        return start;
    }
}