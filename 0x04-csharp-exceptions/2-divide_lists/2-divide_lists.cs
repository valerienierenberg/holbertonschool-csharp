using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resList = new List<int>();
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    int res = list1[i] / list2[i];
                    resList.Add(res);
                }
                catch (DivideByZeroException)
                {
                    resList.Add(0);
                    Console.WriteLine("Cannot divide by zero");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
        return resList;
    }
}
