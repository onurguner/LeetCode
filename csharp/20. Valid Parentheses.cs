/**
 * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 * 
 * The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
 */
 
public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s))
            return false;
        Stack<char> stack = new Stack<char>();
        for (int i=0; i<s.Length; i++)
        {
            char ch = s[i];
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                char search = (ch == ')') ? '(' : (ch == ']') ? '[' : '{';
                if (stack.Pop() != search)
                    return false;
            }
        }
        return (stack.Count == 0);
    }
}