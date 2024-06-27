namespace June26.CodingQuestion2;

public class MyList<T> : IMyList<T>
{
    private ListNode DummyHead;
    private int Size;

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

    public MyList()
    {
        DummyHead = new ListNode(default(T), null); 
        Size = 0;
    }

    public void Add(T element)
    {
        ListNode newNode = new ListNode(element, null);
        ListNode cur = DummyHead;
        while (cur.Next != null)
        {
            cur = cur.Next;
        }
        cur.Next = newNode;
        Size++;
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= Size)
        {
            throw new IndexOutOfRangeException($"{index} is out of bound");
        }

        ListNode cur = DummyHead;
        for (int i = 0; i < index; i++)
        {
            cur = cur.Next;
        }
        T removedValue = cur.Next.Val;
        cur.Next = cur.Next.Next;
        Size--;
        return removedValue;
    }

    public bool Contains(T element)
    {
        ListNode cur = DummyHead.Next;
        while (cur != null)
        {
            if (cur.Val.Equals(element))
            {
                return true;
            }
            cur = cur.Next;
        }
        return false;
    }

    public void Clear()
    {
        DummyHead.Next = null;
        Size = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > Size)
        {
            throw new IndexOutOfRangeException($"{index} is out of bound");
        }

        ListNode cur = DummyHead;
        for (int i = 0; i < index; i++)
        {
            cur = cur.Next;
        }
        ListNode newNode = new ListNode(element, cur.Next);
        cur.Next = newNode;
        Size++;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= Size)
        {
            throw new IndexOutOfRangeException($"{index} is out of bound");
        }

        ListNode cur = DummyHead;
        for (int i = 0; i < index; i++)
        {
            cur = cur.Next;
        }
        cur.Next = cur.Next.Next;
        Size--;
    }

    public T Find(int index)
    {
        if (index < 0 || index >= Size)
        {
           throw new IndexOutOfRangeException($"{index} is out of bound");
        }

        ListNode cur = DummyHead.Next;
        for (int i = 0; i < index; i++)
        {
            cur = cur.Next;
        }
        return cur.Val;
    }
    
}