using System;


///<summary>Queue Class</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    ///<summary>Check Type Method</summary>
    public Type CheckType()
    {
        return (typeof(T));
    }

    ///<summary>Node class</summary>
    public class Node
    {
        ///<summary>Node Value</summary>
        public T value = default(T);
        ///<summary>Next Node</summary>
        public Node next = null;

        public Node(T n)
        {
            value = n;
        }
    }

    ///<summary>Enqueue Method</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            //tail = newNode;
        }
        else if (tail == null)
        {
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    ///<summary>Dequeue Method</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            return default(T);
        }
        else
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    ///<summary>Count Method</summary>
    public int Count()
    {
        return count;
    }
}

