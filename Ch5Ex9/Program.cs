using System;
using static System.Console;

/*
Write an application named Sum200 that sums the integers from 1 through 200.
Display the running total when the program is halfway complete (after the first 100
numbers), and at the end.
*/

namespace Ch5Ex9
{
	class Program
	{
		static void Main(string[] args)
		{
			int total = 0;
			for (int i = 1; i <= 200; i++)
			{
				total += i;
				if (i == 100) {
					WriteLine($"Running total after 100: {total}");
				}
			}
			WriteLine($"Running total after 200: {total}");
		}
	}
}
