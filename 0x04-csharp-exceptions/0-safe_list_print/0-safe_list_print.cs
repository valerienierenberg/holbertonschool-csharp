using System;
using System.Collections.Generic;
    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            int count = 0;
            try
            {
                for (int i = 0; i <= myList.Count - 1; i++)
                {
                    if (i <= n - 1)
                    {
                        Console.WriteLine(myList[i]);
                        count += 1;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Catch");
            }
            return count;
        }
    }
