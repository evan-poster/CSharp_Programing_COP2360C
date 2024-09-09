using static System.Console;

// Create an enumeration named Month that holds values for the months of the year,
// starting with JANUARY equal to 1. Write a program named MonthNames that prompts
// the user for a month integer. Convert the user’s entry to a Month value, and display it.

class Program
{
	public enum Month { JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER };

	static void Main(string[] args)
	{
		WriteLine("Enter a number from 1 to 12: ");
		int month = int.Parse(ReadLine());

		WriteLine($"You entered {(Month)month}");
	}
}
