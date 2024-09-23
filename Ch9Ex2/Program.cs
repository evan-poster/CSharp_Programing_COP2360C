using System;
using static System.Console;

/*
Create an application named TestClassifiedAd that instantiates and displays at least
two ClassifiedAd objects. A ClassifiedAd has fields for a category (for example,
Used Cars), a number of words, and a price. Include properties that contain get and
set accessors for the category and number of words, but only a get accessor for the
price. The price is calculated at nine cents per word.
*/

namespace Ch9Ex2
{
	class ClassifiedAd
	{
		// Declare fields
		private string category;
		private int numWords;

		public ClassifiedAd(string category, int numWords)
		{
			this.category = category;
			this.numWords = numWords;
		}

		public string Category
		{
			get { return category; }
			set { category = value; }
		}

		public int NumWords
		{
			get { return numWords; }
			set { numWords = value; }
		}

		public double Price
		{
			get { return 0.09 * numWords; }
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ClassifiedAd ad1 = new ClassifiedAd("Used Cars", 10);
			ClassifiedAd ad2 = new ClassifiedAd("Real Estate", 5);

			WriteLine($"Category: {ad1.Category}, Number of words: {ad1.NumWords}, Price: {ad1.Price:C}");
			WriteLine($"Category: {ad2.Category}, Number of words: {ad2.NumWords}, Price: {ad2.Price:C}");
		}
	}
}
