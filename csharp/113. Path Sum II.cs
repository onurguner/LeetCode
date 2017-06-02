/*
Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.

For example:
Given the below binary tree and sum = 22,
              5
             / \
            4   8
           /   / \
          11  13  4
         /  \    / \
        7    2  5   1
return
[
   [5,4,11,2],
   [5,8,4,5]
]
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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) {
            return result;
        }
        
        IList<int> path = new List<int>();
        
        pathSumHelper(root, sum, path, ref result);
        
        return result;
    }
    
    private void pathSumHelper(TreeNode node, int target, IList<int> path, ref IList<IList<int>> result) {
        if (node == null) {
            return;
        }
        
        path.Add(node.val);
        
        if (node.left == null && node.right == null && node.val == target) {
            result.Add(new List<int>(path));
        }
        else {
            pathSumHelper(node.left, target - node.val, path, ref result);
            pathSumHelper(node.right, target - node.val, path, ref result);
        }
        path.RemoveAt(path.Count - 1);
    }
    
}