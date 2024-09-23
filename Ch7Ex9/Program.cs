using System;
using static System.Console;

/*
Write a program named CountVowelsModularized that passes a string to a method
that returns the number of vowels in the string.
*/

namespace Ch7Ex5 {
	class CountVowelsModularized {

		static void Main(string[] args) {
			WriteLine("Enter a phrase:");
			string phrase = ReadLine();
			WriteLine($"There are {CountVowels(phrase)} vowel(s) in the phrase.");
		}

		static int CountVowels(string phrase) {
			int count = 0;
			phrase = phrase.ToUpper();
			for (int i = 0; i < phrase.Length; i++) {
				if (phrase[i] == 'A' || phrase[i] == 'E' || phrase[i] == 'I' || phrase[i] == 'O' || phrase[i] == 'U') {
					count++;
				}
			}
			return count;
		}
	}
}