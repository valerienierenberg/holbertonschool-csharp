using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        // initialize node to head of linked list
        LinkedListNode<int> current = myLList.First;
        while (current != null)
        {
            if (current.Value > n)
            {
                myLList.AddBefore(current, newNode);
                break;
            }
            // if we made it to the end of the linked list and there wasn't a number higher than n, put the node at the end of the list
            if (current.Next == null)
            {
                myLList.AddAfter(current, newNode);
                break;
            }
            current = current.Next;
        }
        return (newNode);
    }
}
