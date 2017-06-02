
/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;

        int val = 0, carry = 0;
        while (l1 != null && l2 != null)
        {
            val = l1.val + l2.val + carry;
            carry = val / 10;
            prev.next = new ListNode(val % 10);
            prev = prev.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 != null)
        {
            val = l1.val + carry;
            carry = val / 10;
            prev.next = new ListNode(val % 10);
            prev = prev.next;
            l1 = l1.next;
        }

        while (l2 != null)
        {
            val = l2.val + carry;
            carry = val / 10;
            prev.next = new ListNode(val % 10);
            prev = prev.next;
            l2 = l2.next;
        }

        if (carry == 1)
        {
            prev.next = new ListNode(1);
        }

        return dummy.next;        
    }
}