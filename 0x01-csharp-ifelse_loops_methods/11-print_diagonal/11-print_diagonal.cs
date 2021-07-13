using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length != 0)
        {
            for (int index = 0; index < length; index++)
            {
                for (int spaces = 0; spaces < index; spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\\n");
            }
            Console.Write("\n");
        } else
            Console.Write("\n");
    }
}
