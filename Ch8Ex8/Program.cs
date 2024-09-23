using System;
using static System.Console;
// using System.Linq;

/*
Write a program named SortWords that includes a method that accepts any number
of words and sorts them in alphabetical order. Demonstrate that the program works
correctly when the method is called with one, two, five, and ten words.
*/

namespace Ch8Ex8 {
	class Program
	{
		static void Main(string[] args)
		{
			SortWords("hello");
			SortWords("world", "hello");
			SortWords("hello", "world", "abc", "xyz", "def");
			SortWords("hello", "world", "abc", "xyz", "def", "pqr", "mno", "stu", "vwx", "yz");
		}

		static void SortWords(params string[] words)
		{
			Array.Sort(words);
			WriteLine(string.Join(", ", words));
		}
	}
}
