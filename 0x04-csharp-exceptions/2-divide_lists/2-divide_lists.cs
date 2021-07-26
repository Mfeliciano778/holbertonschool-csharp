using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newList = new List<int>();
        
        for (int index = 0; index < listLength; index++)
        {
            try
            {
                int sum = list1[index] / list2[index];
                newList.Add(sum);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                newList.Add(0);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return newList;
    }
}