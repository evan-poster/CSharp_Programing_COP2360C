using System;
using static System.Console;

/*
a. Create a program named Reverse3 whose Main() method declares three integers
named firstInt, middleInt, and lastInt. Assign values to the variables,
display them, and then pass them to a method that accepts them as reference
variables, places the first value in the lastInt variable, and places the last value
in the firstInt variable. In the Main() method, display the three variables again,
demonstrating that their positions have been reversed.

b. Create a new program named Reverse4, which contains a method that reverses
the positions of four variables. Write a Main() method that demonstrates the
method works correctly.
*/

namespace Ch8Ex1
{
	class Reverse
	{
		static void Main()
		{
			// First with 3 variables
			// Declare and initialize variables
			int firstInt = 1;
			int middleInt = 2;
			int lastInt = 3;

			// Display variables
			WriteLine($"firstInt = {firstInt}, middleInt = {middleInt}, lastInt = {lastInt}");

			// Pass variables to method
			Reverse3(ref firstInt, ref middleInt, ref lastInt);

			// Display variables
			WriteLine($"firstInt = {firstInt}, middleInt = {middleInt}, lastInt = {lastInt}");

			// Now 4 variables

			// Declare and initialize variables
			int firstInt2 = 1;
			int secondInt = 2;
			int thirdInt = 3;
			int fourthInt = 4;

			// Display variables
			WriteLine($"firstInt2 = {firstInt2}, secondInt = {secondInt}, thirdInt = {thirdInt}, fourthInt = {fourthInt}");

			// Pass variables to method
			Reverse4(ref firstInt2, ref secondInt, ref thirdInt, ref fourthInt);

			// Display variables
			WriteLine($"firstInt2 = {firstInt2}, secondInt = {secondInt}, thirdInt = {thirdInt}, fourthInt = {fourthInt}");
		}

		static void Reverse3(ref int firstInt, ref int middleInt, ref int lastInt)
		{
			int temp = firstInt;
			firstInt = lastInt;
			lastInt = temp;
		}

		static void Reverse4(ref int firstInt, ref int secondInt, ref int thirdInt, ref int fourthInt)
		{
			// Declare temp variables
			int temp = firstInt;
			int temp2 = secondInt;

			// Swap
			firstInt = fourthInt;
			secondInt = thirdInt;
			thirdInt = temp2;
			fourthInt = temp;
		}
	}
}
