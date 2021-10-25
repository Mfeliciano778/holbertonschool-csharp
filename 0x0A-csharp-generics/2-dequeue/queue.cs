using System;

/// <summary>
/// Class for a Queue
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Variable that holds the head node
    /// </summary>
    public Node head;
    /// <summary>
    /// Variable that holds the tail node
    /// </summary>
    public Node tail;
    /// <summary>
    /// Variable that holds the number of nodes
    /// </summary>
    public int count = 0;

    /// <summary>
    /// Checks the type of the Queue
    /// </summary>
    /// <returns> The type of Queue </returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Node class
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value of the node
        /// </summary>
        public T value = default(T);
        /// <summary>
        /// Variable that holds the next node
        /// </summary>
        public Node next = null;

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="t"> value we are setting</param>
        public Node(T t)
        {
            value = t;
        }
    }

    /// <summary>
    /// Creates a node and adds it to the Queue
    /// </summary>
    /// <param name="val"> Value in the node </param>
    public void Enqueue(T val)
    {
        Node newNode = new Node(val);
        if (head == null)
        {
            head = newNode;
        } else
        {
            tail.next = newNode;
        }
        tail = newNode;
        count++;
    }

    /// <summary>
    /// Returns the number of nodes
    /// </summary>
    /// <returns> Number of nodes </returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Dequeue removes the first node and returns the value
    /// </summary>
    /// <returns> the value of the first node </returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T Temp = head.value;
        head = head.next;
        count -= 1;
        return Temp;
    }
}
