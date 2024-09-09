using static System.Console;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 197;
            int hours = minutes / 60;
            minutes = minutes % 60;

            WriteLine($"{hours} hours and {minutes} minutes.");
        }
    }
}
