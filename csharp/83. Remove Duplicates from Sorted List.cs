/**
 * Given a sorted linked list, delete all duplicates such that each element appear only once.
 * 
 * For example,
 * Given 1->1->2, return 1->2.
 * Given 1->1->2->3->3, return 1->2->3.
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
        if (head == null)
            return null;
        ListNode curr = head;
        while (curr != null && curr.next != null)
        {
            if (curr.next.val == curr.val)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }
        
        return head;
    }
}