/**
 * Given a 2D board containing 'X' and 'O' (the letter O), capture all regions surrounded by 'X'.
 * 
 * A region is captured by flipping all 'O's into 'X's in that surrounded region.
 * 
 * For example,
 * X X X X
 * X O O X
 * X X O X
 * X O X X
 * After running your function, the board should be:
 * 
 * X X X X
 * X X X X
 * X X X X
 * X O X X
 * 
 * Breadth-first Search, Union Find
 */
 
public class Solution {
    public void Solve(char[,] board) {
        if (board == null || board.Length == 0)
            return;
        
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        
        Queue<Point> queue = new Queue<Point>();
        
        for (int i=0; i<rows; i++)
        {
            if (board[i, 0] == 'O')
            {
                board[i, 0] = 'B';
                queue.Enqueue(new Point(i, 0));
            }
            if (board[i, cols-1] == 'O')
            {
                board[i, cols-1] = 'B';
                queue.Enqueue(new Point(i, cols-1));
            }
        }
        for (int j=0; j<cols; j++)
        {
            if (board[0, j] == 'O')
            {
                board[0, j] = 'B';
                queue.Enqueue(new Point(0, j));
            }
            if (board[rows-1, j] == 'O')
            {
                board[rows-1, j] = 'B';
                queue.Enqueue(new Point(rows-1, j));
            }
        }
        
        while (queue.Count != 0)
        {
            Point p = queue.Dequeue();
            int row = p.x;
            int col = p.y;
            
            if (row>0 && board[row-1, col] == 'O') { board[row-1, col] = 'B'; queue.Enqueue(new Point(row-1, col)); }
            if (row<rows-1 && board[row+1, col] == 'O') { board[row+1, col] = 'B'; queue.Enqueue(new Point(row+1, col)); }
            
            if (col>0 && board[row, col-1] == 'O') { board[row, col-1] = 'B'; queue.Enqueue(new Point(row, col-1)); }
            if (col<cols-1 && board[row, col+1] == 'O') { board[row, col+1] = 'B'; queue.Enqueue(new Point(row, col+1)); }
        }
        
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<cols; j++)
            {
                if (board[i, j] == 'O') board[i, j] = 'X';
                if (board[i, j] == 'B') board[i, j] = 'O';
            }
        }
    }
}