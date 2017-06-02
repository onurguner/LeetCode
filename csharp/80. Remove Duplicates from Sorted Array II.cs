/**
 * Follow up for "Remove Duplicates":
 * What if duplicates are allowed at most twice?
 * 
 * For example,
 * Given sorted array nums = [1,1,1,2,2,3],
 * 
 * Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. It doesn't matter what you leave beyond the new length.
 */
 
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int nSize = nums.Length;
        if (nSize < 3)
            return nSize;
            
        int nRunner = 2, nCurr = 2;
        while (nRunner < nSize)
        {
            if (nums[nRunner] != nums[nCurr - 2])
            {
                nums[nCurr++] = nums[nRunner];
            }
            nRunner++;
        }
        return nCurr;
    }
}