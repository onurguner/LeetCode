
/*
Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

For example,
Given input array nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the new length.
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        if (nums.Length < 2) {
            return 1;
        }
        
        int size = 1;
        for (int i=1; i<nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[size++] = nums[i];
            }
        }
        return size;
    }
}