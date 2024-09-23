using System;
using static System.Console;

/*
Create a program named IntegerFacts whose Main() method declares an array of
10 integers. Call a method to interactively fill the array with any number of values up
to 10 or until a sentinel value is entered. If an entry is not an integer, reprompt the
user. Call a second method that accepts out parameters for the highest value in the
array, lowest value in the array, sum of the values in the array, and arithmetic average.
In the Main() method, display all the statistics.
*/

namespace Ch8Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int count = GetValues(numbers);
            int highest, lowest, sum;
            double average;

            GetStatistics(numbers, count, out highest, out lowest, out sum, out average);

            WriteLine($"Highest value: {highest}");
            WriteLine($"Lowest value: {lowest}");
            WriteLine($"Sum of values: {sum}");
            WriteLine($"Average of values: {average:F2}");
        }

        static int GetValues(int[] numbers)
        {
            int count = 0;
            while (count < numbers.Length)
            {
                Write("Enter an integer (or -1 to finish): ");
                if (int.TryParse(ReadLine(), out int number) && number != -1)
                {
                    numbers[count] = number;
                    count++;
                }
                else if (number == -1)
                {
                    break;
                }
                else
                {
                    WriteLine("Invalid input. Please try again.");
                }
            }
            return count;
        }

        static void GetStatistics(int[] numbers, int count, out int highest, out int lowest, out int sum, out double average)
        {
            highest = numbers[0];
            lowest = numbers[0];
            sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }
                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            average = (double)sum / count;
        }
    }
}
