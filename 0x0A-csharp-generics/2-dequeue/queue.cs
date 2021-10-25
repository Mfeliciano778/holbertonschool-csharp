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

        public void contructor(T t)
        {
            value = t;
        }
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node();
        if (count == 0)
        {
            head = newNode;
            newNode.next = tail;
        } else
        {
            tail = newNode;
            newNode.next = null;
        }
        newNode.value = value;
        count++;
    }

    public int Count()
    {
        return count;
    }

    public T Dequeue()
    {
        T Temp;

        if (count == 0)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }

        Temp = head.value;
        head = head.next;
        count--;
        return Temp;
    }
}
