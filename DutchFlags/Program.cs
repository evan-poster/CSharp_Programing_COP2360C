using System;
using System.Linq;
using static System.Console;

namespace DutchFlags
{
	class Program
	{
		public enum Flags
		{
			D = 0,
			F,
			G
		}
		
		static void Main(string[] args)
		{
			Flags[] flags = { Flags.D, Flags.F, Flags.D, Flags.G, Flags.D, Flags.F };
			// expected output: {D, D, D, F, F, G}

			int[] flag_counts = new int[3];

			for (int i = 0; i < flags.Length; i++)
			{
				switch (flags[i])
				{
					case Flags.D:
						flag_counts[0]++;
						break;
					case Flags.F:
						flag_counts[1]++;
						break;
					case Flags.G:
						flag_counts[2]++;
						break;
				}
			}

			// Output new array based on counts
			string result = string.Concat(
				Enumerable.Repeat("D", flag_counts[0])
				.Concat(Enumerable.Repeat("F", flag_counts[1]))
				.Concat(Enumerable.Repeat("G", flag_counts[2]))
			);

			WriteLine(result);
		}
	}
}
