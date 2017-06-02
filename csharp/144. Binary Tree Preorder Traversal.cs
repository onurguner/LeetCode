/*
Given a binary tree, return the preorder traversal of its nodes' values.

For example:
Given binary tree {1,#,2,3},
   1
    \
     2
    /
   3
return [1,2,3].

Note: Recursive solution is trivial, could you do it iteratively?
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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        if (root == null) {
            return result;
        }
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        TreeNode curr = null;
        while (stack.Count != 0) {
            curr = stack.Pop();
            result.Add(curr.val);
            if (curr.right != null)
                stack.Push(curr.right);
            if (curr.left != null)
                stack.Push(curr.left);
        }
        return result;
    }
}