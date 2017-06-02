/**
 * Given an array of integers, find if the array contains any duplicates. 
 * Your function should return true if any value appears at least twice in the array, 
 * and it should return false if every element is distinct.
 */

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
            HashSet<int> table = new HashSet<int>();
            foreach (int num in nums)
            {
                if (table.Contains(num))
                {
                    return true;
                }
                else
                {
                    table.Add(num);
                }
            }
            return false;
    }
}