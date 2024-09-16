using System;
using static System.Console;

/*
Write a program for The Carefree Resort named ResortPrices that prompts the user to enter the number of days for a resort stay.

Then display the price per night and the total price.

- Nightly rates are $200 for one or two nights
- $180 for three or four nights
- $160 for five, six, or seven nights; and $145 for eight nights or more
*/

namespace Ch6Ex8
{
	class Program
	{
		static void Main(string[] args)
		{
			// Greet user
			WriteLine("The Carefree Resort");
			WriteLine("Resort Price Calculator");

			// Prompt user to enter number of days
			Write("Enter number of days: ");
			int days = int.Parse(ReadLine());

			// Calculate price
			int price = 0;
			if (days <= 2)
			{
				price = 200;
			}
			else if (days <= 4)
			{
				price = 180;
			}
			else if (days <= 7)
			{
				price = 160;
			}
			else
			{
				price = 145;
			}

			// Display price
			WriteLine($"Price per night: ${price}");
			WriteLine($"Total price: ${price * days}");
		}
	}
}