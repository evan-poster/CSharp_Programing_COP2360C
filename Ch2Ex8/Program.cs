using static System.Console;

namespace ProjectedRaisesInteractive
{
	class Program
	{
		private const float RAISE = 1.04f;

		static void Main(string[] args)
		{
			WriteLine("Enter the salary for the first employee: ");
			float salary1 = float.Parse(ReadLine());

			WriteLine("Enter the salary for the second employee: ");
			float salary2 = float.Parse(ReadLine());

			WriteLine("Enter the salary for the third employee: ");
			float salary3 = float.Parse(ReadLine());

			WriteLine($"Next year's salary for the first employee: {(salary1 * RAISE).ToString("C")} (raise: {(salary1 * RAISE - salary1).ToString("C")})");
			WriteLine($"Next year's salary for the second employee: {(salary2 * RAISE).ToString("C")} (raise: {(salary2 * RAISE - salary2).ToString("C")})");
			WriteLine($"Next year's salary for the third employee: {(salary3 * RAISE).ToString("C")} (raise: {(salary3 * RAISE - salary3).ToString("C")})");
		}
	}
}
