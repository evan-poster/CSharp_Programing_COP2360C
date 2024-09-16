using System;
using static System.Console;
using System.Linq;

namespace MaxSubArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
			// int[] nums = { 7, 1, 5, 3, 6, 4 };
			// int [] nums = { 45, 55, 90, 30, 120, 20, 200, 90, 110, 115};
			
			int max_profit = 0;
			int min_price = nums[0];

			for (int i = 0; i < nums.Length; i++)
			{
				// Update min_price if current element is less
				min_price = Math.Min(min_price, nums[i]);
				// Update max_profit if current element is greater
				max_profit = Math.Max(max_profit, nums[i] - min_price);
			}

			// Display results
			// WriteLine($"Max subarray: {nums[current_min]} ({current_min}) & {nums[current_max]} ({current_max})");
			WriteLine($"Max difference: {max_profit}");
		}
	}
}
