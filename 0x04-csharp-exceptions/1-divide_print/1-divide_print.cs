using System;

class Int
{
    public static void divide(int a, int b)
    {
        int sum = 0;
        try
        {
            sum = a / b;
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {sum}");
        }
    }
}
