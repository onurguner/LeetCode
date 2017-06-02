/**
 Given a positive integer, return its corresponding column title as appear in an Excel sheet.

For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 
 */
 
public class Solution {
    public string ConvertToTitle(int n) {
        string result = "";
        while (n > 0)
        {
            n--;
            result = (char)('A' + (n % 26)) + result;
            n = n / 26;
        }
        return result;
    }
}