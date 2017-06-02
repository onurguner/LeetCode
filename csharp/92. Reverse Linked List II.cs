/*
Reverse a linked list from position m to n. Do it in-place and in one-pass.

For example:
Given 1->2->3->4->5->NULL, m = 2 and n = 4,

return 1->4->3->2->5->NULL.

Note:
Given m, n satisfy the following condition:
1 ≤ m ≤ n ≤ length of list.
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
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if (head == null || m == n)
            return head;
        
        ListNode prevHead = new ListNode(0);
        prevHead.next = head;
        
        ListNode prev = prevHead;
        for (int i = 1; i < m; i++)
        {
            prev = prev.next;
        }
        ListNode start = prev.next;
        ListNode next = start.next;
        
        for (int j = 0; j < n-m; j++)
        {
            start.next = next.next;
            next.next = prev.next;
            prev.next = next;
            next = start.next;
        }
        
        return prevHead.next;
    }
}