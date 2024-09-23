using System;
using static System.Console;

/*
Write a program named Averages that includes a method that accepts any number of
numeric parameters, displays them, and displays their average. Demonstrate that the
method works correctly when passed one, two, or three numbers, or an array of numbers.
*/

namespace Ch8Ex7
{
	class Program
	{
		static void Main(string[] args)
		{
			Average(1);
			Average(1, 2);
			Average(1, 2, 3);
			Average(new int[] { 1, 2, 3 });
		}

		static void Average(params int[] numbers)
		{
			WriteLine("Numbers: " + string.Join(", ", numbers));
			WriteLine("Average: " + numbers.Average());
			WriteLine();
		}
	}
}
