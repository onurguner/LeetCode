/*
Write a program to find the node at which the intersection of two singly linked lists begins.


For example, the following two linked lists:

A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
begin to intersect at node c1.


Notes:

If the two linked lists have no intersection at all, return null.
The linked lists must retain their original structure after the function returns.
You may assume there are no cycles anywhere in the entire linked structure.
Your code should preferably run in O(n) time and use only O(1) memory.
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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) {
            return null;
        }
        
        ListNode currA = headA, currB = headB;
        
        int m = 0;
        while (currA != null) {
            currA = currA.next;
            m++;
        }
        
        int n = 0;
        while (currB != null) {
            currB = currB.next;
            n++;
        }
        
        currA = headA;
        if (m > n) {
            for (int i=0; i<m-n; i++) {
                currA = currA.next;
            }
        }
        
        currB = headB;
        if (m < n) {
            for (int i=0; i<n-m; i++) {
                currB = currB.next;
            }
        }
        
        while (currA != null && currB != null) {
            if (currA == currB) {
                return currA;
            }
            currA = currA.next;
            currB = currB.next;
        }
        return null;
    }
}