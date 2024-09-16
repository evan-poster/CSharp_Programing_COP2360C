using System;
using static System.Console;

/*
In Chapter 4, you created a program that generates a random number, allows a user to
guess it, and displays a message indicating whether the guess is too low, too high, or
correct. Now, create a modified program called GuessingGame2 in which the user
can continue to enter values until the correct guess is made. After the user guesses
correctly, display the number of guesses made.
*/

namespace Ch5Ex14
{
	class Program
	{
		private static int maxValue = 10;

		static void Main(string[] args)
		{
			// Greet user and explain basic rules
			WriteLine("Guessing Game");
			WriteLine("Guess a number between 1 and " + maxValue);

			// Generate random number for game
			Random random = new Random();
			int randomNumber = random.Next(1, maxValue + 1);

			// Initialize variables
			int guess;
			int guessCount = 0;
			bool correct = false;

			// Main loop
			while (!correct)
			{
				// Prompt user
				Write("Enter your guess: ");
				guess = int.Parse(ReadLine());

				// Increment guess count
				guessCount++;

				// Check if guess is correct
				if (guess == randomNumber)
				{
					WriteLine("You guessed correctly!");
					correct = true;
				}
				else
				{
					WriteLine("Wrong guess...");
				}
			}

			// Display results
			WriteLine();
			WriteLine("You guessed the number after " + guessCount + " attempt(s)!");
		}
	}
}
