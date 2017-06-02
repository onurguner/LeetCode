/*
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

You are given a target value to search. If found in the array return its index, otherwise return -1.

You may assume no duplicate exists in the array.
*/

public class Solution {
    public int Search(int[] nums, int target) {
        if (nums == null || nums.Length == 0) {
            return -1;
        }
        
        int iSize = nums.Length;
        int iStart = getStartIndex(nums);
        int iEnd = iStart + iSize - 1;
        int iMid = 0, iIndex = 0;
        while (iStart <= iEnd) {
            iMid = iStart + (iEnd - iStart) / 2;
            iIndex = iMid % iSize;
            if (target == nums[iIndex]) {
                return iIndex;
            } else if (target < nums[iIndex]) {
                iEnd = iMid - 1;
            } else {
                iStart = iMid + 1;
            }
        }
        return -1;
    }
    
    private int getStartIndex(int[] nums) {
        for (int i=0; i<nums.Length-1; i++) {
            if (nums[i] > nums[i+1]) {
                return i+1;
            }
        }
        return 0;
    }
}