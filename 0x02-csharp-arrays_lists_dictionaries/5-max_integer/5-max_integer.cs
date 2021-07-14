using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count > 0)
        {
            int max = 0;
            for (int index = 0; index < myList.Count; index++)
            {
                if (myList[index] > max)
                    max = myList[index];
            }
            return max;
        }
        Console.WriteLine("List is empty");
        return -1;
    }
}
