/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:

string convert(string text, int nRows);
convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
*/

public class Solution {
    public string Convert(string s, int numRows) {
        if (string.IsNullOrEmpty(s) || numRows == 1) {
            return s;
        }
        int length = s.Length, index = 0;
        string[] sRows = new string[numRows];
        while (index < length) {
            for (int i=0; i<numRows && index < length; i++) {
                sRows[i] += s[index++];
            }
            for (int i=numRows-2; i>=1 && index < length; i--) {
                sRows[i] += s[index++];
            }
        }
        string result = "";
        for (int i=0; i<numRows; i++) {
            result += sRows[i];
        }
        return result;
    }
}