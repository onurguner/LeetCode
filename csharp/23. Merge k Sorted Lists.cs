/**
 * Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
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
    public struct Element
    {
        public ListNode node;
        public int index;
    }
    
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0)
            return null;
            
        SortedSet<Element> minHeap = new SortedSet<Element>(new ByValComparer());
        for (int i=0; i<lists.Length; i++)
        {
            if (lists[i] != null)
            {
                Element elem = new Element();
                elem.node = lists[i];
                elem.index = i;
                
                minHeap.Add(elem);
            }
        }
        
        ListNode tempList = new ListNode(0);
        ListNode mergedList = tempList;
        while (minHeap.Count != 0)
        {
            Element item = minHeap.Min;
            minHeap.Remove(item);
            
            tempList.next = item.node;
            tempList = tempList.next;
            
            if (item.node.next != null)
            {
                Element elem = new Element();
                elem.node = item.node.next;
                elem.index = item.index;
                
                minHeap.Add(elem);
            }
        }
        return mergedList.next;
    }
    
    public class ByValComparer : IComparer<Element>
    {
        public int Compare(Element x, Element y)
        {
            int result = x.node.val.CompareTo(y.node.val);
            if (result == 0)
            {
                result = x.index.CompareTo(y.index);
            }
            return result;
        }
    }
}