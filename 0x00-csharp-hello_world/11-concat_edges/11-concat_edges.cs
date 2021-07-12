using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Substring(49, 80);
		Console.WriteLine("{0} {1} {3} {2} ", str.Substring(0, 15), str.Substring(31, 11), str.Substring(53, 2), str.Substring(70, 2));
    }
}