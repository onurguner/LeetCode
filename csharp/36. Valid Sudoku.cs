
/*
Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.

The Sudoku board could be partially filled, where empty cells are filled with the character '.'.


A partially filled sudoku which is valid.

Note:
A valid Sudoku board (partially filled) is not necessarily solvable. Only the filled cells need to be validated.
*/
public class Solution {
    public bool IsValidSudoku(char[,] board) {
        if (board == null || board.Length == 0) {
            return false;
        }
        
        if (board.GetLength(0) != 9 || board.GetLength(1) != 9) {
            return false;
        }
        
        int x, y;
        for (int i=0; i<9; i++) {
            
            if (isValid(board, i, i, 0, 8) == false) {
                return false;
            }
            
            if (isValid(board, 0, 8, i, i) == false) {
                return false;
            }
            
            x = (i % 3) * 3;
            y = (i / 3) * 3;
            if (isValid(board, x, x+2, y, y+2) == false) {
                return false;
            }
        }
        
        return true;
    }
    
    private bool isValid(char[,] board, int x1, int x2, int y1, int y2) {
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