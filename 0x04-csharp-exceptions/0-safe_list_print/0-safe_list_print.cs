using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int index = 0;
        try
        {

            for (index = 0; index < n; index++)
            {
                Console.WriteLine($"{myList[index]}");
            }
            return index;
        }
        catch (System.ArgumentOutOfRangeException)
        {
            return index;
        }
    }
}
