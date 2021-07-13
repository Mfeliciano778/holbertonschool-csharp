using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string result;
        if ((number % 10) > 5)
            result = "greater than 5";
        else if ((number % 10) == 0)
            result = "0";
        else
            result = "less than 6 and not 0";
        Console.WriteLine("The last digit of {0} is {1} and is {2}", number, number % 10, result);
    }
}
