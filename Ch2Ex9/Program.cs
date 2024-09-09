using static System.Console;

namespace MoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rates
            float flat_rate = 200.0f;
            float hour_rate = 150.0f;
            float mile_rate = 2.0f;

            // 1: Ask for input from user
            WriteLine("Enter number of hours: ");
            float hours = Convert.ToSingle(ReadLine());
            WriteLine("Enter number of miles: ");
            float miles = Convert.ToSingle(ReadLine());

            // 2: Provide results
            float total = flat_rate + (hour_rate * hours) + (mile_rate * miles);
            WriteLine($"Total moving fee: ${total}");
        }
    }
}
