using System;
using System.Collections.Generic;
using static System.Console;

/*
Create a program named ConferencesDemo for a hotel that hosts business conferences.

Allows a user to enter data about five Conference objects
	and then displays them in order of attendance from smallest to largest.

The Conference class contains fields for the
	Conference group name,
	starting date (as a string),
	and number of attendees.

Include properties for each field.

Also, include an IComparable.CompareTo() method so that Conference objects can be sorted.
*/

namespace Ch9Ex8
{
	class Conference : IComparable
	{
		// Fields
		public string GroupName { get; set; }
		public string StartDate { get; set; }
		public int NumAttendees { get; set; }

		// Constructor
		public Conference(string groupName, string startDate, int numAttendees)
		{
			GroupName = groupName;
			StartDate = startDate;
			NumAttendees = numAttendees;
		}

		// Methods
		public int CompareTo(object obj)
		{
			Conference conference = obj as Conference;
			if (conference != null)
			{
				return this.NumAttendees.CompareTo(conference.NumAttendees);
			}
			else
			{
				throw new ArgumentException("Object is not a Conference");
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Conference> conferences = new List<Conference>();

			for (int i = 0; i < 5; i++)
			{
				WriteLine("Enter data for conference");
				Write("Enter group name: ");
				string groupName = ReadLine();
				Write("Enter starting date: ");
				string startDate = ReadLine();
				Write("Enter number of attendees: ");
				int numAttendees = int.Parse(ReadLine());

				conferences.Add(new Conference(groupName, startDate, numAttendees));
			}

			conferences.Sort();

			foreach (var conference in conferences)
			{
				WriteLine($"{conference.GroupName} {conference.StartDate} {conference.NumAttendees}");
			}
		}
	}
}

