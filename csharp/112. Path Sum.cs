/**
 * Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.
 * 
 * For example:
 * Given the below binary tree and sum = 22,
 *               5
 *              / \
 *             4   8
 *            /   / \
 *           11  13  4
 *          /  \      \
 *         7    2      1
 * return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
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
    public bool HasPathSum(TreeNode root, int sum) {
        int count = 0, record = 0;
        PathSum(root, ref count, record, sum);
        return (count > 0);
    }
    
    private void PathSum(TreeNode node, ref int count, int record, int sum)
    {
        if (node == null)
            return;
        
        record += node.val;
        if (record == sum)
        {
            if (node.left == null && node.right == null)
            {
                count++;
            }
        }
        
        PathSum(node.left, ref count, record, sum);
        PathSum(node.right, ref count, record, sum);
    }
}