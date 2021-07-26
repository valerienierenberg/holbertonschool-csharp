using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        List<int> uniqList = new List<int>();
        uniqList = myList.Distinct().ToList();
        for (int i = 0; i < uniqList.Count; i++)
        {
            sum += uniqList[i];
        }
        return sum;
    }
}
