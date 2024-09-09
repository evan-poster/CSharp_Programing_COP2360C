using static System.Console;

class StopSign {

	static void Main(string[] args) {
		string[] stopSign = new string[] {
			"  XXXXXX",
			" X      X",
			"X  STOP  X",
			" X      X",
			"  XXXXXX",
			"     X",
			"     X",
			"     X"
		};

		foreach (string line in stopSign) {
			WriteLine(line);
		}

		string[] letter_h = new string[] {
			"H       H",
			"H       H",
			"HHHHHHHHH",
			"H       H",
			"H       H",
		};

		foreach (string line in letter_h) {
			WriteLine(line);
		}
	}
}
