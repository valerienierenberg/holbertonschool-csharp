using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var multDict = new Dictionary<string, int>();
        foreach(var item in myDict)
        {
            multDict.Add(item.Key, item.Value * 2);
        }
        return multDict;
    }
}
