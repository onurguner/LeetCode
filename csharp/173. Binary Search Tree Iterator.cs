/*
Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.

Calling next() will return the next smallest number in the BST.

Note: next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
*/


/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {
    private Stack<TreeNode> nodes = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        addToStack(root);
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return hasNext();
    }

    /** @return the next smallest number */
    public int Next() {
        return next();
    }
    
    private void addToStack(TreeNode root) {
        TreeNode node = root;
        while (node != null) {
            nodes.Push(node);
            node = node.left;
        }
    }
    
    private bool hasNext() {
        return (nodes.Count != 0);
    }
    
    private int next() {
        TreeNode current = nodes.Pop();
        addToStack(current.right);
        return current.val;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */