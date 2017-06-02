/**
 * Reverse a singly linked list.
 * 
 * Hint:
 * A linked list can be reversed either iteratively or recursively. Could you implement both?
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
    public ListNode ReverseList(ListNode head) {
            ListNode prev = null, next = null;
            ListNode curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
    }
}