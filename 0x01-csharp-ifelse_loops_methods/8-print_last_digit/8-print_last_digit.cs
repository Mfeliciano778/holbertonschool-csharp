using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        Console.Write((number % 10) < 0 ? (number % 10) * -1 : number % 10);
        return (number % 10) < 0 ? (number % 10) * -1 : number % 10;
    }
}
