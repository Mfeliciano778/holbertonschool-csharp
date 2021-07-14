using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> newList = new List<int>();

        for (int index = 0; index < size; index++)
        {
            newList.Add(index);
        }
        Console.WriteLine("{0}", string.Join(" ", newList));
        return newList;
    }
}