/**
Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.

You may assume the integer do not contain any leading zero, except the number 0 itself.

The digits are stored such that the most significant digit is at the head of the list.
 */

public class Solution {
    public int[] PlusOne(int[] digits) {
        if (digits == null || digits.Length == 0)
            return null;
        
        IList<int> digitsOne = new List<int>();
        
        int iEnd = digits.Length - 1;
        int iSum = 0, iCarry = 1;
        for (int i = iEnd; i >= 0; i--)
        {
            iSum = (digits[i] + iCarry);
            iCarry = 0;
            if (iSum == 10)
            {
                iSum = 0;
                iCarry = 1;
            }
            digitsOne.Insert(0, iSum);
        }
        if (iCarry == 1)
        {
            digitsOne.Insert(0, 1);
        }
        return digitsOne.ToArray();
    }
}