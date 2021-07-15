﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0 || myLList == null)
        {
            return 0;
        }
        int headValue = myLList.First.Value;
        myLList.RemoveFirst();
        return headValue;
    }
}
