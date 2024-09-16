using System;
using static System.Console;

/*
Write a program named TestScoreList that accepts eight int values representing
student test scores. Display each of the values along with a message that indicates how
far it is from the average.
*/

namespace Ch6Ex2
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Enter test scores:");
			int[] scores = new int[8];
			for (int i = 0; i < 8; i++)
			{
				scores[i] = int.Parse(ReadLine());
			}

			int sum = 0;
			for (int i = 0; i < 8; i++)
			{
				sum += scores[i];
			}

			int average = sum / 8;

			WriteLine($"Average score: {average}");

			for (int i = 0; i < 8; i++)
			{
				if (scores[i] < average)
				{
					WriteLine($"{scores[i]} is below average by {average - scores[i]} points.");
				}
				else if (scores[i] == average)
				{
					WriteLine($"{scores[i]} is average.");
				}
				else
				{
					WriteLine($"{scores[i]} is above average by {scores[i] - average} points.");
				}
			}
		}
	}
}
