using System;
using System.Linq;
using static System.Console;

/*
Create a lottery game application named Lottery. Generate three random numbers,
each between 1 and 4. Allow the user to guess three numbers. Compare each of the
user’s guesses to the three random numbers, and display a message that includes the
user’s guess, the randomly determined three-digit number, and the amount of money
the user has won as follows:

Matching Numbers				Award ($)
Any one matching				10
Two matching					100
Three matching, not in order	1000
Three matching in exact order	10000
No matches						0

Make certain that your application accommodates repeating digits. For example, if a
user guesses 1, 2, and 3, and the randomly generated digits are 1, 1, and 1, do not give
the user credit for three correct guesses—just one.
*/

namespace Ch4Ex9
{
	class Program
	{
		static void Main(string[] args)
		{
			// Initialize award
			int award = 0;
			int matches = 0;

			// Generate three random numbers
			Random random = new Random();
			int [] winningNumbers = [random.Next(1, 5), random.Next(1, 5), random.Next(1, 5)];

			// Allow the user to guess three numbers
			WriteLine("Enter 3 numbers between 1 and 4:");
			int [] userNumbers = [int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine())];

			// Check for three matching numbers, in order
			if (userNumbers[0] == winningNumbers[0] && userNumbers[1] == winningNumbers[1] && userNumbers[2] == winningNumbers[2])
			{
				award = 10000;
				matches = 3;
				WriteLine("JACKPOT!!!");
			} else {
				// Old Method

				// int [] userCounts = {
				// 	userNumbers.Count(n => n == 1),
				// 	userNumbers.Count(n => n == 2),
				// 	userNumbers.Count(n => n == 3),
				// 	userNumbers.Count(n => n == 4)
				// };

				// int [] winningCounts = {
				// 	winningNumbers.Count(n => n == 1),
				// 	winningNumbers.Count(n => n == 2),
				// 	winningNumbers.Count(n => n == 3),
				// 	winningNumbers.Count(n => n == 4)
				// };

				// Slightly better method

				int [] userCounts = new int[4];
				int [] winningCounts = new int[4];

				for(int i = 0; i < winningNumbers.Length; i++) {
					userCounts[userNumbers[i]-1]++;
					winningCounts[winningNumbers[i]-1]++;
				}

				int [] finalCount = [
					int.Min(userCounts[0], winningCounts[0]),
					int.Min(userCounts[1], winningCounts[1]),
					int.Min(userCounts[2], winningCounts[2]),
					int.Min(userCounts[3], winningCounts[3])
				];

				// The sum of our finalCount array is our total matching numbers
				int sum = finalCount.Sum();
				if (sum == 3)
				{
					award = 1000;
				} else if (sum == 2)
				{
					award = 100;
				} else if (sum == 1)
				{
					award = 10;
				}
				matches = sum;				
			}
				
			// Display user's award
			WriteLine($"Winning ticket:\t{winningNumbers[0]}, {winningNumbers[1]}, {winningNumbers[2]}");
			WriteLine($"Your guess:\t{userNumbers[0]}, {userNumbers[1]}, {userNumbers[2]}");
			WriteLine($"You had {matches} matching number(s)");
			WriteLine($"Your award is {award:C0}");
		}
	}
}
