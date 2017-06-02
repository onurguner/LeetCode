
/*
Given a string, find the length of the longest substring without repeating characters.

Examples:

Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        int max = 0, start = 0;
        Dictionary<char, int> table = new Dictionary<char, int>();
        for (int i=0; i<s.Length; i++) {
            if (table.ContainsKey(s[i])) {
                int index = table[s[i]];
                if (start <= index) {
                    max = Math.Max(max, i - start);
                    start = index + 1;
                }
                table[s[i]] = i;
            } else {
                table.Add(s[i], i);
            }
        }
        max = Math.Max(max, s.Length - start);
        return max;
    }
}