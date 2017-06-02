/*
A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.

Return a deep copy of the list.
*/


/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if (head == null)
        {
            return null;
        }
        
        RandomListNode curr = head;
        while (curr != null)
        {
            RandomListNode next = curr.next;
            RandomListNode copy = new RandomListNode(curr.label);
            curr.next = copy;
            copy.next = next;
            curr = next;
        }
    
        curr = head;
        while (curr != null)
        {
            RandomListNode copy = curr.next;
            copy.random = (curr.random != null) ? curr.random.next : null;
            curr = copy.next;
        }
    
        curr = head;
        RandomListNode dummy = new RandomListNode(0);
        RandomListNode prev = dummy;
        while (curr != null)
        {
            RandomListNode copy = curr.next;
            prev.next = copy;
            curr.next = copy.next;
            prev = prev.next;
            curr = curr.next;
        }
        return dummy.next;
    }
}