/*
Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

For example:
Given the following binary tree,
   1            <---
 /   \
2     3         <---
 \     \
  5     4       <---
You should return [1, 3, 4].
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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> result = new List<int>();
        if (root == null) {
            return result;
        }
        
        
        int numberOfNodes = 1, currentNumberOfNodes = 0;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count != 0) {
            
            while (numberOfNodes > 0) {
                TreeNode node = queue.Dequeue();
                if (node.left != null) {
                    queue.Enqueue(node.left);
                    currentNumberOfNodes++;
                }
                if (node.right != null) {
                    queue.Enqueue(node.right);
                    currentNumberOfNodes++;
                }
                
                numberOfNodes--;
                if (numberOfNodes == 0) {
                    result.Add(node.val);
                }
            }
            numberOfNodes = currentNumberOfNodes;
            currentNumberOfNodes = 0;
        }
        return result;
    }
}