using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int tens = 0; tens <= 9; tens++)
            {
                for (int ones = 1; ones <= 9; ones++)
                {
                    if (tens == ones || ones < tens)
                        continue;
                    else if (tens == 8 && ones == 9)
                        Console.WriteLine("{0}{1}", tens, ones);
                    else
                        Console.Write("{0}{1}, ", tens, ones);
                }
            }
        }
    }
}
