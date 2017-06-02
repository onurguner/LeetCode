/*
Sort a linked list using insertion sort.
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
    public ListNode InsertionSortList(ListNode head) {
        ListNode node = new ListNode(0);
        ListNode curr = head, next = null;
        while (curr != null) {
            next = curr.next;
            ListNode p = node;
            while (p.next != null && p.next.val < curr.val) {
                p = p.next;
            }
            curr.next = p.next;
            p.next = curr;
            curr = next;
        }
        return node.next;
    }
}