/*
All DNA is composed of a series of nucleotides abbreviated as A, C, G, and T, for example: "ACGAATTCCG". When studying DNA, it is sometimes useful to identify repeated sequences within the DNA.

Write a function to find all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.

For example,

Given s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT",

Return:
["AAAAACCCCC", "CCCCCAAAAA"].
*/

public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        IList<string> result = new List<string>();
        if (string.IsNullOrEmpty(s) || s.Length < 10) {
            return result;
        }
        HashSet<int> dict = new HashSet<int>();
        HashSet<int> repeated = new HashSet<int>();
        for (int i=0; i<s.Length - 9; i++) {
            int value = 0;
            for (int j=i; j<i+10; j++) {
                value = value << 2;
                value = value | getCodeIndex(s[j]);
            }
            if (!dict.Add(value) && repeated.Add(value)) {
                result.Add(s.Substring(i, 10));
            }
        }
        return result;
    }
    
    private int getCodeIndex(char code) {
        if (code == 'A')
            return 0;
        else if (code == 'C')
            return 1;
        else if (code == 'G')
            return 2;
        else 
            return 3;
    }
}