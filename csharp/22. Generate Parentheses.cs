/*
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

For example, given n = 3, a solution set is:

[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]
*/


public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        generateParenthesis("", n, n, ref result);
        return result;
    }
    
    private void generateParenthesis(string paran, int i, int j, ref IList<string> result) {
        if (i == 0 && j == 0) {
            result.Add(paran);
            return;
        }
        
        if (i > 0) {
            generateParenthesis(paran + "(", i - 1, j, ref result);
        }
        
        if (i < j) {
            generateParenthesis(paran + ")", i, j - 1, ref result);
        }
    }
}