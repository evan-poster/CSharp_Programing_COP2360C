using System;
using static System.Console;

namespace NameSort
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine(SortNames("John", "Mary", "Jane", "Bob"));
		}

		static string SortNames(params string[] names)
		{
			Array.Sort(names);
			return string.Join(", ", names);
		}
	}
}
