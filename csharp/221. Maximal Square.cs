/*
Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

For example, given the following matrix:

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0
Return 4.
*/

public class Solution {
    public int MaximalSquare(char[,] matrix) {
        if (matrix == null || matrix.Length == 0)
            return 0;
            
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];
        int max = 0;
        
        for (int i=0; i<cols; i++)
        {
            result[0, i] = matrix[0, i] - '0';
            if (result[0, i] == 1)
                max = 1;
        }
        
        for (int i=0; i<rows; i++)
        {
            result[i, 0] = matrix[i, 0] - '0';
            if (result[i, 0] == 1)
                max = 1;
        }
        
        for (int i=1; i<rows; i++)
        {
            for (int j=1; j<cols; j++)
            {
                if (matrix[i, j] == '1')
                {
                    result[i, j] = 1 + getMin(result[i-1, j], result[i, j-1], result[i-1, j-1]);
                    if (result[i, j] > max)
                        max = result[i, j];
                }
                else
                {
                    result[i, j] = 0;
                }
            }
        }
        return max*max;
    }
    
    private int getMin(int a, int b, int c)
    {
        int min = a < b ? a : b;
        min = min < c ? min : c;
        return min;
    }
}