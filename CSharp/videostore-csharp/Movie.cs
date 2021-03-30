using System;

namespace VideoStore
{
	public class Movie
	{
		public const int CHILDRENS	= 2;
		public const int REGULAR 	= 0;
		public const int NEW_RELEASE = 1;

		public readonly string Title;

		public Movie(string title, int priceCode)
		{
			Title = title;
			PriceCode = priceCode;
		}
		public int PriceCode { get; private set; }
	}
}
