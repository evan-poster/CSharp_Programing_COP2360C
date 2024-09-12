using System;
using static System.Console;

// Write a program named CheckMonth that prompts a user to enter a birth month.
// If the value entered is greater than 12 or less than 1, display an error message;
// otherwise, display the valid month with a message such as 3 is a valid month.

// Write a program named CheckMonth2 that prompts a user to enter a birth month
// and day. Display an error message if the month is invalid (not 1 through 12) or the day
// is invalid for the month (for example, not between 1 and 31 for January or between 1
// and 29 for February). If the month and day are valid, display them with a message.

namespace Ch4Ex5
{
	class Program
	{
		static void Main(string[] args)
		{
			CheckMonth();
			CheckMonth2();
		}

		static void CheckMonth()
		{
			// Prompt the user to enter a birth month.
			Write("Enter a birth month (1-12): ");
			int month = int.Parse(ReadLine());

			// Check for inputs out of range.
			if (month < 1 || month > 12) {
				WriteLine("Invalid month.");
				return;
			}

			// Display the valid month with a message.
			WriteLine($"{month} is a valid month.");
		}

		static void CheckMonth2()
		{
			// Prompt the user to enter a birth month and day.
			Write("Enter a birth month (1-12): ");
			int month = int.Parse(ReadLine());
			Write("Enter a birth day: ");
			int day = int.Parse(ReadLine());

			// Check for inputs out of range.
			if (month < 1 || month > 12) {
				WriteLine("Invalid month.");
				return;
			}
			if (day < 1) {
				WriteLine("Invalid day.");
				return;
			}
			// The length of each month is as follows:
			// 31 days: 1, 3, 5, 7, 8, 10, 12
			// 30 days: 4, 6, 9, 11
			// 28 or 29 days: 2
			switch (month)
			{
				case 2:
					if (day > 29) {
						WriteLine("Invalid day.");
						return;
					}
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					if (day > 30) {
						WriteLine("Invalid day.");
						return;
					}
					break;
				default:
					if (day > 31) {
						WriteLine("Invalid day.");
						return;
					}
					break;
			}

			// Display the valid month and day with a message.
			WriteLine($"{month}/{day} is a valid month and day.");
		}
	}
}
