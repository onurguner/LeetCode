/**
 * Evaluate the value of an arithmetic expression in Reverse Polish Notation.
 * 
 * Valid operators are +, -, *, /. Each operand may be an integer or another expression.
 * 
 * Some examples:
 *   ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
 *   ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
 */
 
public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> operands = new Stack<int>();
        for (int i=0; i<tokens.Length; i++)
        {
            if (IsOperator(tokens[i]) == true)
            {
                int val2 = operands.Pop();
                int val1 = operands.Pop();
                operands.Push(DoMath(val1, val2, tokens[i]));
            }
            else
            {
                operands.Push(Convert.ToInt32(tokens[i]));
            }
        }
        
        return operands.Pop();
    }
    
    private bool IsOperator(string str)
    {
        if (str == "+" || str == "-" || str == "*" || str == "/")
            return true;
        else
            return false;
    }
    
    private int DoMath(int val1, int val2, string opr)
    {
        if (opr == "+")
            return val1+val2;
        else if (opr == "-")
            return val1-val2;
        else if (opr == "*")
            return val1*val2;
        else if (opr == "/")
            return val1/val2;
        
        return 0;
    }
}