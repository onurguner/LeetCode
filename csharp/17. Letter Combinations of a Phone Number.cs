
/*
Given a digit string, return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below.



Input:Digit string "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
Note:
Although the above answer is in lexicographical order, your answer could be in any order you want.
*/

public class Solution {
    private string[] table = new string[] {"0","1","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
    
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>();
        if (digits == null || digits.Length == 0) {
            return result;
        }
        
        combine("", ref digits, 0, ref result);
        return result;
    }
    
    private void combine(string combination, ref string digits, int index, ref IList<string> result) {
        if (index == digits.Length) {
            result.Add(combination);
            return;
        }
        
        int tableIndex = digits[index] - '0';
        string letters = table[tableIndex];
        for (int i=0; i<letters.Length; i++) {
            combine(combination + letters[i], ref digits, index + 1, ref result);
        }
    }
}