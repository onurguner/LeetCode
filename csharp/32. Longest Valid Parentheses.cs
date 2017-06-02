/**
 * Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
 * 
 * For "(()", the longest valid parentheses substring is "()", which has length = 2.
 * 
 * Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
 */
 
public class Solution {
    public int LongestValidParentheses(string s) {
        if (string.IsNullOrEmpty(s))
            return 0;
            
        int maxLength = 0;
        Stack<int> stack = new Stack<int>();
        for (int i=0; i<s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                if (stack.Count != 0)
                {
                    int index = stack.Peek();
                    if (s[index] == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
                else
                {
                    stack.Push(i);
                }
            }
        }
        
        if (stack.Count == 0)
            return s.Length;
       
        int iEnd = s.Length, iStart = 0;
        while (stack.Count != 0)
        {
            iStart = stack.Pop();
            int length = iEnd - iStart - 1;
            if (maxLength < length)
                maxLength = length;
            iEnd = iStart;
        }
        if (maxLength < iEnd)
            maxLength = iEnd;
                
        return maxLength;
    }
}