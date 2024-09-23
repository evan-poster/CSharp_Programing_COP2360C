using System;
using static System.Console;

/*
Write a program named Movie that contains a method that accepts and displays two
parameters: a string name of a movie and an integer running time in minutes. Provide
a default value for the minutes so that if you call the method without an integer
argument, minutes is set to 90. Write a Main() method that proves you can call the
movie method with only a string argument as well as with a string and an integer.
*/

namespace Ch8Ex9
{
	class Program
	{
		static void Movie(string name, int minutes = 90)
		{
			WriteLine($"Name: {name}, Minutes: {minutes}");
		}

		static void Main(string[] args)
		{
			Movie("The Godfather");
			Movie("The Godfather", 180);
		}
	}
}
