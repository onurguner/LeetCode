
/*
Write a function to find the longest common prefix string amongst an array of strings.
*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }
        string str1 = strs[0];
        for (int i=0; i<str1.Length; i++) {
            for (int j=1; j<strs.Length; j++) {
                if ((i > strs[j].Length - 1) || (str1[i] != strs[j][i])) {
                    return str1.Substring(0, i);
                }
            }
        }
        return str1;
    }
}