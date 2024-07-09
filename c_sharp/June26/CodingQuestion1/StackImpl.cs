namespace June26.CodingQuestion1;

public class StackImpl<T> : IStack<T>
{
    private int Size = 0;
    private ListNode DummyHead;

    public StackImpl()
    {
        DummyHead = new ListNode(default(T), null);
    }

    private class ListNode
    {
        public T Val;
        public ListNode Next;

        public ListNode(T val, ListNode next)
        {
            Val = val;
            Next = next;
        }
    }
    
    public int Count()
    {
        return Size;
    }

    public T Pop()
    {
        if (Size == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty");
        }

        T res = DummyHead.Next.Val;
        DummyHead.Next = DummyHead.Next.Next;
        Size--;
        return res;
    }

    public void Push(T item)
    {
        ListNode newNode = new ListNode(item, DummyHead.Next);
        DummyHead.Next = newNode;
        Size++;
        return;
    }
}

