using System;
using static System.Console;

// Accepts a user’s message and determines whether it is short enough
// for a social networking service that does not accept messages of
// more than 140 characters.

namespace Ch4Ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			Write("Enter a message: ");
			string userMessage = ReadLine();

			if (userMessage.Length > 140 || userMessage.Length == 0) {
				WriteLine("Message not accepted.");
			} else {
				WriteLine("Message accepted.");
			}
		}
	}
}
