/**
 * Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
 * 
 * For example:
 * Given binary tree [3,9,20,null,null,15,7],
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * return its bottom-up level order traversal as:
 * [
 *   [15,7],
 *   [9,20],
 *   [3]
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null)
            return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int nextlevelNodeCnt = 0, currLevelNodeCnt = 1;

        TreeNode curr = null;
        while (queue.Count != 0)
        {
            IList<int> levelList = new List<int>();

            while (currLevelNodeCnt != 0)
            {
                curr = queue.Dequeue();
                levelList.Add(curr.val);
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
            currLevelNodeCnt = nextlevelNodeCnt;
            nextlevelNodeCnt = 0;
            result.Insert(0, levelList);
        }
        return result;        
    }
}