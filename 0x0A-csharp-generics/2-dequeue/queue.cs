using System;

class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;

    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T t)
        {
            value = t;
        }
    }

    public void Enqueue(T val)
    {
        Node newNode = new Node(val);
        if (count == 0)
        {
            head = newNode;
            newNode.next = tail;
        } else
        {
            tail = newNode;
            newNode.next = null;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }

        T Temp = head.value;
        head = head.next;
        count--;
        return Temp;
    }
}
