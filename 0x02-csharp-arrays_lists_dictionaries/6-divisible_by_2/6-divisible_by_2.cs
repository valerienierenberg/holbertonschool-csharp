using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> trueFalseList = new List<bool>();
        foreach (int i in myList)
        {
            if ((i % 2) == 0)
            {
                trueFalseList.Add(true);
            }
            else
            {
                trueFalseList.Add(false);
            }
        }
        return trueFalseList;
    }
}