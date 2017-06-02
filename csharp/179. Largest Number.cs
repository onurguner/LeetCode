/*
Given a list of non negative integers, arrange them such that they form the largest number.

For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.

Note: The result may be very large, so you need to return a string instead of an integer.
*/

public class Solution {
    public string LargestNumber(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return "";
        }
        if (nums.Length == 1) {
            return nums[0].ToString();
        }
        
        string[] sNums = new string[nums.Length];
        for (int i=0; i<nums.Length; i++) {
            sNums[i] = nums[i].ToString();
        }
        
        Comparison<string> comparer = new Comparison<string>((s1, s2) => 
        {
            string str1 = s1 + s2;
            string str2 = s2 + s1;
            return str2.CompareTo(str1);
        });
        
        Array.Sort(sNums, comparer);
        
        if (sNums[0][0] == '0') {
            return "0";
        }
        
        string result = "";
        for (int i=0; i<sNums.Length; i++) {
            result += sNums[i];
        }
        return result;
    }
}