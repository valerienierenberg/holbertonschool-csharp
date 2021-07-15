using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (!myLList.Contains(value))
        {
            return (-1);
        }
        else
        {
            int i = myLList.TakeWhile(n => n != value).Count();
            return i;
        }
    }
}
