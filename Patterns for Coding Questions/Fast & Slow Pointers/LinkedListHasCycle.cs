namespace LeetCode.Patterns_for_Coding_Questions.Fast___Slow_Pointers;

public class LinkedListHasCycle
{
    public bool HasCycle(ListNode head) {
        if (head == null || head.Next == null)
            return false;
        
        ListNode fast = head;
        ListNode slow = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast.Next = fast.Next.Next;
            if (slow == fast)
                return true;
        }
        
        return false;
    }
}

public class ListNode {
    public int Val = 0;
    public ListNode Next;

    public ListNode(int value) {
        this.Val = value;
    }
}