using System;
using static System.Console;


/*
a. Write a program named DemoJobs for Harold’s Home Services.

The program should instantiate several Job objects and demonstrate their methods.

The Job class contains four data fields—description (for example, “wash windows”),
	time in hours to complete (for example, 3.5),
	per-hour rate charged (for example, $25.00),
	and total fee (hourly rate times hours).

Include properties to get and set each field except the total fee—that field will be read-only, and its value is calculated each
time either the hourly fee or the number of hours is set.

Overload the + operator so that two Jobs can be added.

The sum of two Jobs is a new Job containing the descriptions of both original Jobs (joined by and), the sum of the time in hours for
the original Jobs, and the average of the hourly rate for the original Jobs.

b. Harold has realized that his method for computing the fee for combined jobs is not fair.

For example, consider the following:
	His fee for painting a house is $100 per hour. If a job takes 10 hours, he earns $1000.
	His fee for dog walking is $10 per hour. If a job takes 1 hour, he earns $10.
	If he combines the two jobs and works a total of 11 hours, he earns only the average rate of $55 per hour, or $605.

Devise an improved, weighted method for calculating Harold’s fees for combined
Jobs and include it in the overloaded operator+() method.

Write a program named DemoJobs2 that demonstrates all the methods in the class work correctly.
*/

namespace Ch9Ex10
{
	class Job
	{
		public string Description { get; set; }
		public double Time { get; set; }
		public double Rate { get; set; }
		public double TotalFee
		{
			get
			{
				return Time * Rate;
			}
		}

		public Job()
		{
		}

		public Job(string description, double time, double rate)
		{
			Description = description;
			Time = time;
			Rate = rate;
		}

		public static Job operator +(Job job1, Job job2)
		{
			return new Job($"{job1.Description} and {job2.Description}", job1.Time + job2.Time, (job1.Rate + job2.Rate) / 2);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Job painting = new Job("painting", 10, 100);
			Job dogWalking = new Job("dog walking", 1, 10);

			Job combined = painting + dogWalking;

			WriteLine($"Job: {combined.Description}");
			WriteLine($"Time: {combined.Time} hours");
			WriteLine($"Rate: {combined.Rate:C2} per hour");
			WriteLine($"Total Fee: {combined.TotalFee:C2}");
		}
	}
}
