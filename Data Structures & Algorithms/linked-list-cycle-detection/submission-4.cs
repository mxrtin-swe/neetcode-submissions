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
    public bool HasCycle(ListNode head) {
        if (head == null)
        {
            return false;
        }
        ListNode it = head;
        ListNode twoStepIt = head.next;
        while (it != null)
        {
            if (twoStepIt == null)
            {
                return false;
            }
            else if (it.val == twoStepIt.val)
            {
                return true;
            }
            it = it.next;
            twoStepIt = twoStepIt.next;
            if (twoStepIt != null)
            {
                twoStepIt = twoStepIt.next;
            }
        }
        return false;
    }
}
