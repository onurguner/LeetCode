/*
Given a linked list, determine if it has a cycle in it.

Follow up:
Can you solve it without using extra space?
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head, runner = head;
        while (runner != null && runner.next != null) {
            slow = slow.next;
            runner = runner.next.next;
            if (slow == runner) {
                return true;
            }
        }
        return false;
    }
}