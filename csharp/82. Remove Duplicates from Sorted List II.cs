/*
Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.

For example,
Given 1->2->3->3->4->4->5, return 1->2->5.
Given 1->1->1->2->3, return 2->3.
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
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null)
            return head;
        
        ListNode prevNewHead = new ListNode(0); 
        prevNewHead.next = head;
        ListNode temp = prevNewHead;
        
        ListNode curr = head;
        while (curr != null) {
            
            while (curr.next != null && curr.val == curr.next.val) {
                curr = curr.next;
            }
            
            if (temp.next == curr) {
                temp = temp.next;
            } else {
                temp.next = curr.next;
            }
            
            curr = curr.next;
        }
        
        return prevNewHead.next;
    }
}