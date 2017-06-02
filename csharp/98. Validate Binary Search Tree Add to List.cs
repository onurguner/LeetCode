/*
Given a binary tree, determine if it is a valid binary search tree (BST).

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
Example 1:
    2
   / \
  1   3
Binary tree [2,1,3], return true.
Example 2:
    1
   / \
  2   3
Binary tree [1,2,3], return false.
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
    public bool IsValidBST(TreeNode root) {
        return IsValidBST(root, null, null);
    }
    
    private bool IsValidBST(TreeNode node, TreeNode minNode, TreeNode maxNode) {
        if (node == null) {
            return true;
        }
        if (((minNode != null) && (node.val <= minNode.val)) || 
            ((maxNode != null) && (node.val >= maxNode.val))) {
            return false;
        } else {
            return IsValidBST(node.left, minNode, node) && IsValidBST(node.right, node, maxNode);
        }
    }
}