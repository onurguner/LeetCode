/**
 * Given a binary tree, return the zigzag level order traversal of its nodes' values. 
 * (ie, from left to right, then right to left for the next level and alternate between).
 * 
 * For example:
 * Given binary tree [3,9,20,null,null,15,7],
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * return its zigzag level order traversal as:
 * [
 *   [3],
 *   [20,9],
 *   [15,7]
 * ]
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null)
            return result;
            
        int nextlevelNodeCnt = 0, currLevelNodeCnt = 1, levelNumber = 0;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        TreeNode curr = null;
        while (queue.Count != 0)
        {
            IList<int> levelList = new List<int>();
            
            while (currLevelNodeCnt != 0)
            {
                curr = queue.Dequeue();
                if (levelNumber % 2 == 0)
                {
                    levelList.Add(curr.val);    
                }
                else
                {
                    levelList.Insert(0, curr.val);
                }
                
                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                    nextlevelNodeCnt++;
                }
                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                    nextlevelNodeCnt++;
                }
                currLevelNodeCnt--;
            }
            levelNumber++;
            
            currLevelNodeCnt = nextlevelNodeCnt;
            nextlevelNodeCnt = 0;
            result.Add(levelList);
        }
        return result;
    }
}