/**
 * Given a roman numeral, convert it to an integer.
 * 
 * Input is guaranteed to be within the range from 1 to 3999.
 */
 
public class Solution {
    public int RomanToInt(string s) {
            Dictionary<char, int> roman = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            int value = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]])
                {
                    value -= roman[s[i]];
                }
                else
                {
                    value += roman[s[i]];
                }
            }
            return value;
    }
}