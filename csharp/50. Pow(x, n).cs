/*
Implement pow(x, n).
*/

public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) 
        {
            return 1.0;
        }
        else if (n < 0)
        {
            return 1.0 / (x * MyPow(x, -(++n)));
        }
        
        return ((n&0x1) == 0) ? MyPow(x*x, n/2) : x*MyPow(x*x, n/2); 
    }
}