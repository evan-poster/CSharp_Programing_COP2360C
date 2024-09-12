using System;
using static System.Console;

// The Saffir-Simpson Hurricane Scale classifies hurricanes into five categories numbered 1 through 5.
// Write an application named Hurricane that outputs a hurricane’s category based on the user’s input of the wind speed.
// Category 5 hurricanes have sustained winds of at least 157 miles per hour.
// The minimum sustained wind speeds for categories 4 through 1 are 130, 111, 96, and 74 miles per hour, respectively.
// Any storm with winds of less than 74 miles per hour is not a hurricane.

namespace Ch4Ex4 {
	class Program {
		static void Main(string[] args) {
			// Get input from user
			Write("Enter wind speed: ");
			float wind = float.Parse(ReadLine());

			// Check for inputs out of range
			if (wind >= 157) {
				WriteLine("Hurricane category: 5");
			} else if (wind >= 130) {
				WriteLine("Hurricane category: 4");
			} else if (wind >= 111) {
				WriteLine("Hurricane category: 3");
			} else if (wind >= 96) {
				WriteLine("Hurricane category: 2");
			} else if (wind >= 74) {
				WriteLine("Hurricane category: 1");
			} else {
				WriteLine("Not a hurricane.");
			}
		}
	}
}
