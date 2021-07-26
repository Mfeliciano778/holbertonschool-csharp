using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int len = myList.Count;
        int index;

        for (index = 0; index < len && index < n; index++)
        {
            Console.WriteLine($"{myList[index]}");
        }
        return index;
    }
}
