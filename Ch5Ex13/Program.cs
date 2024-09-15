using System;
using static System.Console;

/*
Write a program named CountVowels that accepts a phrase from the user and counts
the number of vowels in the phrase. For this exercise, count both uppercase and
lowercase vowels, but do not consider y to be a vowel.
*/

namespace Ch5Ex13
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Enter a phrase:");
			string phrase = ReadLine().ToUpper();
			int count = 0;
			for (int i = 0; i < phrase.Length; i++)
			{
				if (phrase[i] == 'A' || phrase[i] == 'E' || phrase[i] == 'I' || phrase[i] == 'O' || phrase[i] == 'U')
				{
					count++;
				}
			}
			WriteLine($"There are {count} vowels in the phrase.");
		}
	}
}
