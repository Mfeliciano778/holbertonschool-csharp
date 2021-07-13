using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length != 0)
        {
            for (int index = 0; index < length; index++)
            {
                Console.Write("_");
            }
            Console.Write("\n");
        } else
            Console.Write("\n");
    }
}
