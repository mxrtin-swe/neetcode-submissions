/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode previous = head;
        if (previous == null || previous.next == null)
        {
            return head;
        }
        ListNode cur = previous.next;
        if (cur.next == null)
        {
            cur.next = previous;
            head.next = null;
            return cur;
        }
        
        ListNode upcoming = cur.next;   
        while (upcoming != null)
        {
            cur.next = previous;
            previous = cur;
            cur = upcoming;
            upcoming = upcoming.next;
        }
        head.next = null;
        cur.next = previous;
        return cur;
    }
}
