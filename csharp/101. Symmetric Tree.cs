/*
Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

    1
   / \
  2   2
 / \ / \
3  4 4  3
But the following [1,2,2,null,3,null,3] is not:
    1
   / \
  2   2
   \   \
   3    3
Note:
Bonus points if you could solve it both recursively and iteratively.
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
    public bool IsSymmetric(TreeNode root) {
        if (root == null)
        {
            return true;
        }
        return IsSymmetricHelper(root.left, root.right);
    }
    private bool IsSymmetricHelper(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;
        if ((left == null && right != null) || (right == null && left != null))
            return false;
        if (left.val != right.val)
            return false;
            
        return IsSymmetricHelper(left.left, right.right) && IsSymmetricHelper(left.right, right.left);
    }
}