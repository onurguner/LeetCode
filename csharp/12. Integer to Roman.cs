/*
Given an integer, convert it to a roman numeral.

Input is guaranteed to be within the range from 1 to 3999.
*/

public class Solution {
    private string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
    private string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    private string[] hunds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    private string[] thousands = new string[] { "", "M", "MM", "MMM" };
    
    public string IntToRoman(int num) {
        string result = "";
        int level = 0;
        while (num > 0) {
            int remainder = num % 10;
            if (level == 0) {
                result = ones[remainder] + result;    
                level++;
            } else if (level == 1) {
                result = tens[remainder] + result;
                level++;
            } else if (level == 2) {
                result = hunds[remainder] + result;
                level++;
            } else {
                result = thousands[remainder] + result;
            }
            num = num / 10;
        }
        return result;
    }
}