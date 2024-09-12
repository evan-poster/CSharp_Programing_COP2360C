using System;
using static System.Console;

// The user enters a numeric high school grade point average (for example, 3.2) and an admission test score.
// Display the message Accept if the student meets either of the following requirements:
// - A grade point average of 3.0 or higher, and an admission test score of at least 60
// - A grade point average of less than 3.0, and an admission test score of at least 80
// If the student does not meet either of the qualification criteria, display Reject.

namespace Ch4Ex3 {
	class Program {
		static void Main(string[] args) {
			// Get user input for GPA and admission test score, and check qualification criteria.
			Write("Enter grade point average: ");
			float gpa = float.Parse(ReadLine());
			Write("Enter admission test score: ");
			int score = int.Parse(ReadLine());

			// Check for inputs out of range.
			if (gpa < 0.0f || gpa > 4.0f) {
				WriteLine("GPA out of range.");
				return;
			}
			if (score < 0 || score > 100) {
				WriteLine("Score out of range.");
				return;
			}

			// Check qualification criteria.
			if ((gpa >= 3.0f && score >= 60) || (gpa < 3.0f && score >= 80)) {
				WriteLine("Accept");
			} else {
				WriteLine("Reject");
			}
		}
	}
}
