using System;
using static System.Console;

/*
Create an application for a library and name it FineForOverdueBooks. The Main()
method asks the user to input the number of books checked out and the number of
days they are overdue. Pass those values to a method that displays the library fine,
which is 10 cents per book per day for the first seven days a book is overdue, then
20 cents per book per day for each additional day.
*/

namespace Ch7Ex6
{
	class Program
	{
		static void Main(string[] args)
		{
			// Prompt user for number of books checked out
			Write("Enter number of books checked out: ");
			int booksCheckedOut = int.Parse(ReadLine());

			// Prompt user for number of days overdue
			Write("Enter number of days overdue: ");
			int daysOverdue = int.Parse(ReadLine());

			// Pass values to method
			CalculateFine(booksCheckedOut, daysOverdue);
		}

		static void CalculateFine(int booksCheckedOut, int daysOverdue)
		{
			// Calculate fine
			float fine = 0.0;
			float rate = 0.1f;

			if (daysOverdue <= 7)
			{
				fine = daysOverdue * rate;
			}
			else
			{
				fine = 7 * rate + (daysOverdue - 7) * (2 * rate);
			}

			// Display fine
			WriteLine($"Fine: {fine:C2}");
		}
	}
}
