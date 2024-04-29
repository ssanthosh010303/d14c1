/*
 * Author: Sakthi Santhosh
 * Created on: 29/04/2024
 */
public class Solution
{
    public async Task<bool> HasCycle(ListNode head)
    {
        if (head == null) return false;

        ListNode slowPointer = head, fastPointer = head;

        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;

            if (slowPointer == fastPointer) return true;
        }

        return false;
    }
}
