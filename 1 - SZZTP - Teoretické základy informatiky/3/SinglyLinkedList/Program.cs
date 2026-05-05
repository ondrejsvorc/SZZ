public interface ISinglyLinkedList<T>
{
    void AddFirst(T value);
    void AddLast(T value);
    bool Contains(T value);
    bool Remove(T value);
}

public sealed class SinglyLinkedList<T> : ISinglyLinkedList<T>
{
    private Node? _head;

    public void AddFirst(T value)
    {
        Node newNode = new(value);
        newNode.Next = _head;
        _head = newNode;
    }

    public void AddLast(T value)
    {
        Node newNode = new(value);

        if (_head is null)
        {
            _head = newNode;
            return;
        }

        Node current = _head;

        while (current.Next is not null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public bool Contains(T value)
    {
        Node? current = _head;

        while (current is not null)
        {
            if (Equals(current.Value, value))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public bool Remove(T value)
    {
        if (_head is null)
        {
            return false;
        }

        if (Equals(_head.Value, value))
        {
            _head = _head.Next;
            return true;
        }

        Node current = _head;

        while (current.Next is not null)
        {
            if (Equals(current.Next.Value, value))
            {
                current.Next = current.Next.Next;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public override string ToString()
    {
        return "[" + string.Join(" -> ", EnumerateValues()) + "]";
    }

    private IEnumerable<T> EnumerateValues()
    {
        Node? current = _head;

        while (current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    private sealed class Node
    {
        public T Value { get; }
        public Node? Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}

public static class Program
{
    public static void Main()
    {
        SinglyLinkedList<int> list = new();
        list.AddFirst(value: 2);
        list.AddFirst(value: 1);
        list.AddLast(value: 3);
        list.AddLast(value: 4);

        Console.WriteLine(list);
        Console.WriteLine(list.Contains(value: 3));
        Console.WriteLine(list.Remove(value: 1));
        Console.WriteLine(list.Remove(value: 42));
        Console.WriteLine(list);
    }
}