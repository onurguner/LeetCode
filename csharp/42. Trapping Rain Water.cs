/**
 * Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
 * 
 * For example, 
 * Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
 */
 
public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length < 2)
            return 0;
            
        int water = 0;
        int lHeight = 0, rHeight = 0, l = 0, r = height.Length - 1;
        while (l <= r)
        {
            lHeight = Math.Max(lHeight, height[l]);
            rHeight = Math.Max(rHeight, height[r]);
            
            if (lHeight < rHeight)
            {
                water += lHeight - height[l++];
            }
            else
            {
                water += rHeight - height[r--];
            }
        }
        return water;
    }
}