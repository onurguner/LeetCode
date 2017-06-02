/**
 * Given an array of integers, find out whether there are two distinct indices i and j in the array such that 
 * the absolute difference between nums[i] and nums[j] is at most t and the absolute difference between i and j is at most k.
 */
 
public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (nums == null || nums.Length < 2 || k < 1 || t < 0)
            return false;
            
        SortedSet<long> wndSet = null;
        SortedSet<long> bstSet = new SortedSet<long>();
        for (int i=0; i<nums.Length; i++)
        {
            wndSet = bstSet.GetViewBetween((long)nums[i] - (long)t, (long)nums[i] + (long)t);
            if (wndSet != null && wndSet.Count != 0)
                return true;
            
            if (i >= k)
            {
                bstSet.Remove(nums[i - k]);
            }
            
            bstSet.Add(nums[i]);
        }
        
        return false;
    }
}