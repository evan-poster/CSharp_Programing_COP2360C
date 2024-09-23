using System;
using static System.Console;

/*
Create a program named FortuneTeller whose Main() method contains an array of at
least six strings with fortune-telling phrases such as I see a tall, dark stranger in your
future. The program randomly selects two different fortunes and passes them to a
method that displays them.
*/

namespace Ch7Ex5
{
	class Program
	{
		static string[] fortunes = new string[]
		{
			"I see a tall, dark stranger in your future.",
			"Your future depends on you.",
			"If you want it, you'll have to work for it.",
			"Ask your mom.",
			"Your future will be worth it.",
			"Love your family."
		};		
		
		static void Main(string[] args)
		{
			Random random = new Random();
			int index1 = random.Next(0, fortunes.Length);
			int index2 = random.Next(0, fortunes.Length);
			while (index1 == index2)
			{
				index2 = random.Next(0, fortunes.Length);
			}
			DisplayFortune(fortunes[index1], fortunes[index2]);
		}

		static void DisplayFortune(string fortune1, string fortune2)
		{
			WriteLine(fortune1);
			WriteLine(fortune2);
		}
	}
}
