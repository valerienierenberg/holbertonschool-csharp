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
            tail = newNode;
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
            Console.WriteLine("Queue is empty");
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

    ///<summary>Peek Method</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    ///<summary>Print method</summary>
    public void Print()
    {
        Node current = head;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    ///<summary>Concatenate method</summary>
    public string Concatenate()
    {
        Node current = head;
        string result = "";
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (current != null)
        {
            result += current.value;
            if (current != tail && typeof(T) == typeof(string))
            {
                result += " ";
            }
            current = current.next;
        }
        return result;
    }
}
