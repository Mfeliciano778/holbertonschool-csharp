using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        } else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] newArray = new int[size];

        for (int num = 0; num < size; num++)
        {
            newArray[num] = num;
            Console.Write(num < size - 1 ? newArray[num] + " " : newArray[num] + "\n");
        }
        return newArray;
    }
}
