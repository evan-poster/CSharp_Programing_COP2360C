using static System.Console;

// Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an
// application named HomeSales that prompts the user for a salesperson initial (D, E,
// or F ). Either uppercase or lowercase initials are valid. While the user does not type Z,
// continue by prompting for the amount of a sale. Issue an error message for any invalid
// initials entered. Keep a running total of the amounts sold by each salesperson. After
// the user types Z or z for an initial, display each salesperson’s total, a grand total for all
// sales, and the name of the salesperson with the highest total.

namespace Ch5Ex5
{
	class Program
	{
		public enum Salespersons {D,E,F,Z};

		static void Main(string[] args)
		{
			// Declare our variables
			Salespersons salesperson;
			float totalDanielle = 0, totalEdward = 0, totalFrancis = 0;

			// Loop until user types Z
			while (true) {
				Write("Enter salesperson initial (D/E/F, Z to quit): ");
				salesperson = Enum.Parse<Salespersons>(ReadLine().ToUpper());

				if (salesperson != Salespersons.Z) {
					// Query user for sales amount
					Write("Enter sale amount: ");
					float sale = float.Parse(ReadLine());

					// Add to running total per individual
					switch(salesperson) {
						case Salespersons.D:
							totalDanielle += sale;
							break;
						case Salespersons.E:
							totalEdward += sale;
							break;
						case Salespersons.F:
							totalFrancis += sale;
							break;
						default:
							break;
					}
				} else {
					break;
				}
			}

			// Display results
			WriteLine("Total sales by individual:");
			WriteLine($"Danielle:\t{totalDanielle:C}");
			WriteLine($"Edward:\t\t{totalEdward:C}");
			WriteLine($"Francis:\t{totalFrancis:C}");
			WriteLine($"Grand total:\t{totalDanielle + totalEdward + totalFrancis:C}");

			// Determine top performer
			float highest = Math.Max(totalDanielle, totalEdward);
			highest = Math.Max(highest, totalFrancis);
			if (highest == totalDanielle) {
				WriteLine("Danielle is the individual with the highest total.");
			} else if (highest == totalEdward) {
				WriteLine("Edward is the individual with the highest total.");
			} else {
				WriteLine("Francis is the individual with the highest total.");
			}
		}
	}
}
