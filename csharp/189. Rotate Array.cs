
/*
Rotate an array of n elements to the right by k steps.

For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].

Note:
Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.

[show hint]

Related problem: Reverse Words in a String II
*/
public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums == null || nums.Length == 0) {
            return;
        }
        int rotate = k % nums.Length;
        reverseArray(nums, 0, nums.Length - 1);
        reverseArray(nums, 0, rotate - 1);
        reverseArray(nums, rotate, nums.Length - 1);
    }
    
    private void reverseArray(int[] nums, int start, int end) {
        int temp = 0;
        while (start < end) {
            temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
    }
} 