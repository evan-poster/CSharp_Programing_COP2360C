using static System.Console;

// C# program to check if a person can vote or not
// Class exercise from 9/9/2024

class CanYouVote {
	static void Main() {
		WriteLine("Enter your age: ");
		int age = int.Parse(ReadLine());

		WriteLine("Are you a citizen of the United States? (y/n) ");
		string citizen = ReadLine().ToLower();

		if ((citizen == "y") && (age >= 18)) {
			WriteLine("You can vote.");
		} else {
			WriteLine("You can't vote.");
		}
	}
}
