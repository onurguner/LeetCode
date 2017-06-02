/**
 * Write an algorithm to determine if a number is "happy".
 * 
 * A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.
 * 
 * Example: 19 is a happy number
 * 
 * 1^2 + 9^2 = 82
 * 8^2 + 2^2 = 68
 * 6^2 + 8^2 = 100
 * 1^2 + 0^2 + 0^2 = 1
 */
 
public class Solution {
    public bool IsHappy(int n) {
            if (n < 0) return false;
            if (n == 1 || n == 7) return true;
            if (n < 10) return false;

            int num = 0;
            while (n != 0)
            {
                num += (n % 10) * (n % 10);
                n = n / 10;
            }

            return IsHappy(num);        
    }
}