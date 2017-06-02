/**
 * Given a sorted integer array without duplicates, return the summary of its ranges.
 * 
 * For example, given [0,1,2,4,5,7], return ["0->2","4->5","7"].
 */
 
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> sRanges = new List<string>();
        if (nums.Length == 0)
            return sRanges;
            
        int iPivot1 = 0;
        int iPivot2 = 0;
        
        for (int i=0; i<nums.Length-1; i++)
        {
            if (nums[i+1] - nums[i] == 1)
            {
                iPivot2++;    
            }
            else
            {
                if (iPivot2 == iPivot1)
                    sRanges.Add(nums[iPivot1].ToString());
                else
                    sRanges.Add(nums[iPivot1] + "->" + nums[iPivot2]);
                
                iPivot1 = iPivot2 = i + 1;
            }
        }
        
        if (iPivot2 == iPivot1)
            sRanges.Add(nums[iPivot1].ToString());
        else
            sRanges.Add(nums[iPivot1] + "->" + nums[iPivot2]);
                    
        return sRanges;
    }
}