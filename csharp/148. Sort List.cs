/*
Sort a linked list in O(n log n) time using constant space complexity.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        
        ListNode prev = null, slow = head, runner = head;
        while (runner != null && runner.next != null) {
            prev = slow;
            slow = slow.next;
            runner = runner.next.next;
        }
        
        prev.next = null;
        
        ListNode left = SortList(head);
        ListNode right = SortList(slow);
        return merge(left, right);
    }
    
    private ListNode merge(ListNode left, ListNode right) {
        ListNode node = new ListNode(0);
        ListNode temp = node;
        while (left != null && right != null) {
            if (left.val < right.val) {
                temp.next = left;
                left = left.next;
            } else {
                temp.next = right;
                right = right.next;
            }
            temp = temp.next;
        }
        
        if (left != null) {
            temp.next = left;
        }
        
        if (right != null) {
            temp.next = right;
        }
        
        return node.next;
    }
}