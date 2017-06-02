/*
Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
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
    public TreeNode SortedListToBST(ListNode head) {
        int start = 0, end = getSize(head) - 1;
        return getBST(start, end, ref head);
    }
    
    private int getSize(ListNode node) {
        int size = 0;
        while (node != null) {
            node = node.next;
            size++;
        }
        return size;
    }
    
    private TreeNode getBST(int start, int end, ref ListNode node) {
        if (start > end) {
            return null;
        }
        int mid = start + (end - start) / 2;
        TreeNode left = getBST(start, mid - 1, ref node);
        TreeNode parent = new TreeNode(node.val);
        parent.left = left;
        node = node.next;
        TreeNode right = getBST(mid + 1, end, ref node);
        parent.right = right;
        return parent;
    }
}