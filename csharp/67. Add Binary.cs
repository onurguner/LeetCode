/**
 * Given two binary strings, return their sum (also a binary string).
 * 
 * For example,
 * a = "11"
 * b = "1"
 * Return "100".
 */
 
public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carriage = 0;
        int sum = 0;
        string result = "";
        while (i >= 0 || j >= 0 || carriage == 1)
        {
            int na = (i >= 0) ? (a[i--] - '0') : 0;
            int nb = (j >= 0) ? (b[j--] - '0') : 0;
            sum = na ^ nb ^ carriage;
            carriage = (na + nb + carriage >= 2) ? 1 : 0;
            result = sum + result;
        }
        return result;
    }
}