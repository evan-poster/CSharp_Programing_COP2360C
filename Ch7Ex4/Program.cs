using System;
using static System.Console;

/*
Create an application named ConvertMilesToKilometers whose Main() method
prompts a user for a number of miles, passes the value to a method that converts
the value to kilometers, and then returns the value to the Main() method where it is
displayed. A mile is 1.60934 kilometers.
*/

namespace Ch7Ex4 {
	class Program {
		static void Main() {
			// Prompt the user for a number of miles
			WriteLine("Enter a number of miles: ");

			// Convert the value to kilometers
			double miles = double.Parse(ReadLine());

			// Display the result
			WriteLine($"{miles} miles is {ConvertMilesToKilometers(miles)} kilometers.");	
		}

		public static double ConvertMilesToKilometers(double miles) {
			return miles * 1.60934;
		}
	}
}
