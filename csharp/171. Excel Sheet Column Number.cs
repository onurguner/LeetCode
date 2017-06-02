/**
 * Related to question Excel Sheet Column Title
 * 
 * Given a column title as appear in an Excel sheet, return its corresponding column number.
 * 
 * For example:
 * 
 *     A -> 1
 *     B -> 2
 *     C -> 3
 *     ...
 *     Z -> 26
 *     AA -> 27
 *     AB -> 28 
 */

public class Solution {
    public int TitleToNumber(string s) {
            int colNum = 0;
            foreach (char ch in s)
            {
                colNum = (ch - 'A' + 1) + colNum * 26;
            }            
            return colNum;
    }
}