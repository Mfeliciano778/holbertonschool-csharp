using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLList = new LinkedList<int>();

        if (size <= 0)
            return newLList;
        for (int index = 0; index < size; index++)
        {
            newLList.AddLast(index);
        }
        foreach (int item in newLList)
        {
            Console.WriteLine(item);
        }
        return newLList;
    }
}
