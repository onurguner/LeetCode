/**
 * Given a complete binary tree, count the number of nodes.
 * 
 * Definition of a complete binary tree from Wikipedia:
 * In a complete binary tree every level, except possibly the last, 
 * is completely filled, and all nodes in the last level are as far left as possible. 
 * It can have between 1 and 2h nodes inclusive at the last level h.
 */
 
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int CountNodes(TreeNode root) {
        if (root == null)
        {
            return 0;
        }
        int height = 0;
        TreeNode left = root, right = root;
        while (right != null)
        {
            left = left.left;
            right = right.right;
            height++;
        }
        
        if (left == null)
        {
            return (1 << height) - 1;
        }
        
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    } 
}