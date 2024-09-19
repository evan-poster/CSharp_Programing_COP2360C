using System;
using static System.Console;

/*
Create a program named PaintingEstimate whose Main() method prompts a user
for length and width of a room in feet. Create a method that accepts the values and
then computes the cost of painting the room, assuming the room is rectangular and
has four full walls and 9-foot ceilings. The price of the job is $6 per square foot. Return
the price to the Main() method, and display it.
*/

namespace Ch7Ex3
{
	class Program
	{
		public static double height = 9;
		public static double price = 6;


		static void Main(string[] args)
		{
			WriteLine("Enter length: ");
			double length = double.Parse(ReadLine());

			WriteLine("Enter width: ");
			double width = double.Parse(ReadLine());
			
			double price = CalculatePrice(length, width);
			WriteLine($"Price: {price:C2}");
		}

		static double CalculatePrice(double length, double width)
		{
			return price * 2 * ( (length * height) + (width * height) );
		}
	}
}
