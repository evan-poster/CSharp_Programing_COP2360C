using static System.Console;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter number of eggs for chicken 1: ");
            int chicken1 = int.Parse(ReadLine());

            Write("Enter number of eggs for chicken 2: ");
            int chicken2 = int.Parse(ReadLine());

            Write("Enter number of eggs for chicken 3: ");
            int chicken3 = int.Parse(ReadLine());

            Write("Enter number of eggs for chicken 4: ");
            int chicken4 = int.Parse(ReadLine());

            int total = chicken1 + chicken2 + chicken3 + chicken4;

            int dozens = total / 12;
            int eggs = total % 12;

            WriteLine($"{total} eggs is {dozens} dozen and {eggs} eggs.");
        }
    }
}

