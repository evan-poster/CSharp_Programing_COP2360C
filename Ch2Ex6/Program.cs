using static System.Console;

namespace InchesToCentimetersInteractive
{
    class Program
    {
        private const float CentimetersPerInch = 2.54f;

        static void Main(string[] args)
        {
            Write("Enter number of inches: ");
            float inches = Convert.ToSingle(ReadLine());
            float centimeters = inches * CentimetersPerInch;
            WriteLine($"{inches} inches is {centimeters} centimeters");
        }
    }
}
