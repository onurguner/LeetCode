
/*
Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.

You may not alter the values in the nodes, only nodes itself may be changed.

Only constant memory is allowed.

For example,
Given this linked list: 1->2->3->4->5

For k = 2, you should return: 2->1->4->3->5

For k = 3, you should return: 3->2->1->4->5
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || head.next == null || k < 2) {
            return head;
        }
        int group = 0;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode curr = head, prev = dummy;
        while (curr != null) {
            group++;
            if (group % k == 0) {
                prev = reverseList(prev, curr.next);
                curr = prev.next;
            } else {
                curr = curr.next;
            }
        }
        return dummy.next;
    }
    
    private ListNode reverseList(ListNode prev, ListNode tail) {
        ListNode p = prev.next;
        ListNode q = p.next;
        while (q != tail) {
            p.next = q.next;
            q.next = prev.next;
            prev.next = q;
            q = p.next;
        }
        return p;
    }
}