/**
 * Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.
 * 
 * Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
 * 
 * Note:
 * You are not suppose to use the library's sort function for this problem.
 * 
 * Follow up:
 * A rather straight forward solution is a two-pass algorithm using counting sort.
 * First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
 * 
 * Could you come up with an one-pass algorithm using only constant space?
 */
 
public class Solution {
    public void SortColors(int[] nums) {
        if (nums == null || nums.Length == 0)
            return;
        
        int index1=0, index2=nums.Length-1, index = 0;
        while (index <= index2)
        {
            if (nums[index] > 1)
            {
                swap(nums, index, index2);
                index2--;
            }
            else 
            {
                if (nums[index] == 0)
                {
                    swap(nums, index, index1);
                    index1++;
                }
                index++;
            }
        }
    }
    
    private void swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}