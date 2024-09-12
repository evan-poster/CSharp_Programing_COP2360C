using System;
using static System.Console;

// Prompts users to enter a purchase price for an item.
// If the value entered is greater than a credit limit of $8,000, display an error message; otherwise, display Approved.

namespace Ch4Ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Enter purchase price: ");
			float purchasePrice = float.Parse(ReadLine());
			if (purchasePrice > 8000)
			{
				WriteLine("Purchase price exceeds credit limit.");
			}
			else
			{
				WriteLine("Approved");
			}
		}
	}
}
