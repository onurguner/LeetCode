/*

Given a binary tree, return the postorder traversal of its nodes' values.

For example:
Given binary tree {1,#,2,3},
   1
    \
     2
    /
   3
return [3,2,1].

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
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        if (root == null) {
            return result;
        }
        
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;
        while (curr != null || stack.Count != 0) {
            if (curr != null) {
                stack.Push(curr);
                result.Insert(0, curr.val);
                curr = curr.right;
            } else {
                curr = stack.Pop();
                curr = curr.left;
            }
        }
        return result;
    }
}