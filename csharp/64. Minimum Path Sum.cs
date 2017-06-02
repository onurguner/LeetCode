/*
Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.
*/

public class Solution {
    public int MinPathSum(int[,] grid) {
        if (grid == null || grid.Length == 0) {
            return 0;
        }
        
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int[,] S = new int[rows, cols];
        
        S[0, 0] = grid[0, 0];
        for (int i=1; i<rows; i++) {
            S[i, 0] = S[i-1, 0] + grid[i, 0];
        }
        for (int j=1; j<cols; j++) {
            S[0, j] = S[0, j-1] + grid[0, j];
        }
        for (int i=1; i<rows; i++) {
            for (int j=1; j<cols; j++) {
                S[i, j] = grid[i, j] + Math.Min(S[i-1, j], S[i, j-1]);
            }
        }
        return S[rows-1, cols-1];
    }
}