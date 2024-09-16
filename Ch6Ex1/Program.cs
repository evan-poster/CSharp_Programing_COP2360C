using System;
using static System.Console;

/*
Write a program named ArrayDemo that stores an array of 10 integers. Until the user
enters a sentinel value, allow the user four options:
	(1) to view the list in order from the first to last position in the stored array.
	(2) to view the list in order from the last to first position.
	(3) to choose a specific position to view.
	(4) to quit the application.
*/

namespace Ch6Ex1
{
	class Program
	{
		public static void ListOptions() {
			// List options for user:
			WriteLine("Enter 1 to view the list in order from the first to last position in the stored array.");
			WriteLine("Enter 2 to view the list in order from the last to first position.");
			WriteLine("Enter 3 to choose a specific position to view.");
			WriteLine("Enter 4 to quit the application.");
		}

		static void Main()
		{
			// Randomized 10 integers
			Random random = new Random();
			int[] array = {random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11), random.Next(1, 11)};

			ListOptions();

			// Enter our loop
			while (true)
			{
				// Prompt user
				Write("Enter a number (0 for help): ");
				int number = int.Parse(ReadLine());
				if (number == 0)
				{
					ListOptions();
				} else {
					switch(number) {
						case 1:
							// View in order from first to last
							for (int i = 0; i < array.Length; i++)
							{
								Write("{0} ", array[i]);
							}
							WriteLine();
							break;
						case 2:
							// View in order from last to first
							for (int i = array.Length - 1; i >= 0; i--)
							{
								Write("{0} ", array[i]);
							}
							WriteLine();
							break;
						case 3:
							// Choose a position
							Write("Enter a position to view: ");
							int position = int.Parse(ReadLine());
							WriteLine(array[position]);
							break;
						case 4:
							// Exit
							return;
						default:
							WriteLine("Invalid input.");
							break;
					}
				}
			}
		}
	}
}
