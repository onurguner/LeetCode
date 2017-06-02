/**
 * Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words. You may assume the dictionary does not contain duplicate words.
 * 
 * For example, given
 * s = "leetcode",
 * dict = ["leet", "code"].
 * 
 * Return true because "leetcode" can be segmented as "leet code".
 */
 
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        int len = s.Length;
        
        bool[] table = new bool[len+1];
        table[0] = true;
        for (int i=0; i<len; i++)
        {
            if (table[i] == false)
                continue;
                
            for (int j=i+1; j<=len; j++)
            {
                if (wordDict.Contains(s.Substring(i, j-i)))
                {
                    table[j] = true;
                } 
            }
        }
        
        return table[len];
    }
}