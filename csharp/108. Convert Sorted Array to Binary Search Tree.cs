/*
Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return null;
        }
        int start = 0, end = nums.Length - 1;
        return arrayToBST(nums, start, end);
    }
    
    private TreeNode arrayToBST(int[] nums, int start, int end) {
        if (start > end) {
            return null;
        }
        
        int mid = start + (end - start) / 2;
        TreeNode parent = new TreeNode(nums[mid]);
        parent.left = arrayToBST(nums, start, mid - 1);
        parent.right = arrayToBST(nums, mid + 1, end);
        return parent;
    }
}