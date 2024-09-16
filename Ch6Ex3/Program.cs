using System;
using static System.Console;

/*
Write a program named TemperaturesComparison that allows a user to input five daily Fahrenheit temperatures that must range from −30 to 130;

if a temperature is out of range, require the user to reenter it.

If no temperature is lower than any previous one, display a message Getting warmer.

If every temperature is lower than the previous one, display a message Getting cooler.

If the temperatures are not entered in either ascending or descending order, display a message It’s a mixed bag.

Finally, display the temperatures in the order they were entered, and then display the average of the temperatures.
*/

namespace Ch6Ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] temperatures = new int[5];
			int count = 0;

			// Get temperatures from user
			while (count < 5)
			{
				Write("Enter a temperature: ");
				int temperature = int.Parse(ReadLine());
				if (temperature < -30 || temperature > 130)
				{
					WriteLine("Temperature must be between -30 and 130");
					continue;
				}
				temperatures[count] = temperature;
				count++;
			}

			// Check if temperatures are in ascending/descending order
			int warmer = 0, cooler = 0;
			for (int i = 0; i < 4; i++)
			{
				if (temperatures[i] < temperatures[i + 1])
				{
					warmer++;
				}
				else if (temperatures[i] > temperatures[i + 1])
				{
					cooler++;
				}
			}

			// Display message based on temperatures order
			if (warmer == 4) {
				WriteLine("Getting warmer");
			} else if (cooler == 4) {
				WriteLine("Getting cooler");
			} else {
				WriteLine("It's a mixed bag");
			}

			// Display temperatures in order of entry and average
			Write("Temperatures: ");
			for (int i = 0; i < 5; i++)
			{
				Write($"{temperatures[i]} ");
			}
			WriteLine();
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				sum += temperatures[i];
			}
			WriteLine($"Average: {sum / 5}");
		}
	}
}
