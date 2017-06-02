
/*
Write a program to solve a Sudoku puzzle by filling the empty cells.

Empty cells are indicated by the character '.'.

You may assume that there will be only one unique solution.
*/

public class Solution {
    public void SolveSudoku(char[,] board) {
        if (board == null || board.Length == 0) {
            return;
        }
        if (board.GetLength(0) != 9 || board.GetLength(1) != 9) {
            return;
        }
        solve(board);
    }
    
    private bool solve(char[,] board) {
        for (int i=0; i<9; i++) {
            for (int j=0; j<9; j++) {
                if (board[i, j] != '.')
                    continue;
                for (char c='1'; c<='9'; c++) {
                    board[i, j] = c;
                    if (isValid(board, i, j) && solve(board)) {
                        return true;
                    }
                    board[i, j] = '.';
                }
                return false;
            }
        }
        return true;
    }
    
    private bool isValid(char[,] board, int i, int j) {
        if (isValidCell(board, i, i, 0, 8) == false) {
            return false;
        }
        if (isValidCell(board, 0, 8, j, j) == false) {
            return false;
        }
        int x = (i / 3) * 3;
        int y = (j / 3) * 3;
        if (isValidCell(board, x, x+2, y, y+2) == false) {
            return false;
        }
        return true;
    }
    
    private bool isValidCell(char[,] board, int x1, int x2, int y1, int y2) {
        HashSet<char> table = new HashSet<char>();
        for (int i=x1; i<=x2; i++) {
            for (int j=y1; j<=y2; j++) {
                if (board[i, j] != '.' && !table.Add(board[i, j])) {
                    return false;
                }
            }
        }
        return true;
    }
}