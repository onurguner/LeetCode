/**
 * Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
 * 
 * If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
 * 
 * The replacement must be in-place, do not allocate extra memory.
 * 
 * Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
 * 	1,2,3 → 1,3,2
 * 	3,2,1 → 1,2,3
 * 	1,1,5 → 1,5,1
 */
 
public class Solution {
    public void NextPermutation(int[] nums) {
        int iPivot = nums.Length - 1;
        while (iPivot >= 1 && nums[iPivot] <= nums[iPivot - 1])
        {
            iPivot--;
        }
        if (iPivot > 0)
        {
            int k = nums.Length - 1;
            while (k>iPivot && nums[k] <= nums[iPivot - 1])
            {
                k--;
            }
            nums[iPivot - 1] = nums[iPivot - 1] ^ nums[k] ^ (nums[k] = nums[iPivot - 1]);
        }
        
        int i = iPivot, j = nums.Length - 1;
        for (; i<j; i++, j--)
        {
            nums[i] = nums[i] ^ nums[j] ^ (nums[j] = nums[i]); 
        }
    }
}