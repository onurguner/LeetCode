/*
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Write a function to determine if a given target is in the array.

The array may contain duplicates.
*/

public class Solution {
    public bool Search(int[] nums, int target) {
        if (nums == null || nums.Length == 0) {
            return false;
        }
        
        int iStart = 0, iMid = 0, iEnd = nums.Length - 1;
        while (iStart <= iEnd) {
            iMid = iStart + (iEnd - iStart) / 2;
            if (nums[iMid] == target) {
                return true;
            }
            
            if (nums[iStart] < nums[iMid]) {//left sorted
                if (nums[iStart] <= target && target < nums[iMid]) {
                    iEnd = iMid - 1;
                } else {
                    iStart = iMid + 1;
                }
            } else if (nums[iStart] > nums[iMid]) {//right sorted
                if (nums[iMid] < target && target <= nums[iEnd]) {
                    iStart = iMid + 1;
                } else {
                    iEnd = iMid - 1;
                }
            } else {
                iStart++;
            }
        }
        
        return false;
    }
}