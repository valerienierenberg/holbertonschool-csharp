using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        var max = myList.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        return max;
    }
}
