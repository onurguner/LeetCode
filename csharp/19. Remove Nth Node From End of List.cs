/*
Given a linked list, remove the nth node from the end of list and return its head.

For example,

   Given linked list: 1->2->3->4->5, and n = 2.

   After removing the second node from the end, the linked list becomes 1->2->3->5.
Note:
Given n will always be valid.
Try to do this in one pass.
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null) {
            return null;
        }
        
        ListNode temp = head;
        for (int i=0; i<n; i++) {
            temp = temp.next;
        }
        ListNode prev = null, curr = head;
        while (temp != null) {
            prev = curr;
            curr = curr.next;
            temp = temp.next;
        }
        
        if (prev == null) {
            head = head.next;
        } else {
            prev.next = curr.next;
        }
        
        return head;
    }
}