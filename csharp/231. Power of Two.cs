/**
 * Given an integer, write a function to determine if it is a power of two.
 */
 
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n == 1)
            return true;
        if (n <= 0)
            return false;
        if (n % 2 != 0)
            return false;

        return IsPowerOfTwo(n / 2);
    }
}