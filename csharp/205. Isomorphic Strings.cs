/*
Given two strings s and t, determine if they are isomorphic.

Two strings are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.

For example,
Given "egg", "add", return true.

Given "foo", "bar", return false.

Given "paper", "title", return true.

Note:
You may assume both s and t have the same length.
*/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, char> table = new Dictionary<char, char>();
        for (int i=0; i<s.Length; i++) {
            if (table.ContainsKey(s[i]) == false) {
                if (table.ContainsValue(t[i])) {
                    return false;
                }
                table.Add(s[i], t[i]);
            } else {
                if (table[s[i]] != t[i]) {
                    return false;
                }
            }
        }
        return true;
    }
}