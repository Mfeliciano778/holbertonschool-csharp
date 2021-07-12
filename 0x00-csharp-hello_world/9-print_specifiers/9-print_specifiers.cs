using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		double sum = percent + currency;
        Console.WriteLine("${0}", sum.ToString("0.00"));
	}
}