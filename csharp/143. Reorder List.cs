/*
Given a singly linked list L: L0→L1→…→Ln-1→Ln,
reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…

You must do this in-place without altering the nodes' values.

For example,
Given {1,2,3,4}, reorder it to {1,4,2,3}.
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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
            {
                return;
            }
            //split list into two
            ListNode head2 = split(head);
            //reverse list starting at head2
            head2 = reverse(head2);
            //reorder one by one
            ListNode p1 = head;
            ListNode p2 = head2;
            while (p1 != null && p2 != null)
            {
                ListNode q1 = p1.next;
                ListNode q2 = p2.next;
                p1.next = p2;
                p2.next = q1;
                p1 = q1;
                p2 = q2;
            }
            return;
    }
    
    private ListNode split(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode slow = head, fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            fast = slow.next;
            slow.next = null;
            return fast;
        }

    private ListNode reverse(ListNode head)
        {
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