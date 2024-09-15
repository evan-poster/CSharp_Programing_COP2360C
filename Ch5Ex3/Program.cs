using System;
using static System.Console;

/*
Write an application named EnterUppercaseLetters that asks the user to type an
uppercase letter from the keyboard. If the character entered is an uppercase letter,
display OK; if it is not an uppercase letter, display an error message. The program
continues until the user types an exclamation point.
*/

namespace Ch5Ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool running = true;

			while (running) {
				Write("Enter an uppercase letter (! to quit): ");
				char letter = char.Parse(ReadLine());
				if (char.IsUpper(letter)) {
					WriteLine("OK");
				} else {
					if (letter == '!') {
						running = false;
					} else {
						WriteLine("Error");
					}
				}
			}
		}	
	}
}
