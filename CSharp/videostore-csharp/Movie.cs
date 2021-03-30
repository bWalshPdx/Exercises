using System;

namespace VideoStore
{
	public class Movie
	{
		public const int CHILDRENS	= 2;
		public const int REGULAR 	= 0;
		public const int NEW_RELEASE = 1;

		private readonly string _title;

		public string Title => _title;

		public Movie(string title, int priceCode)
		{
			_title = title;
			PriceCode = priceCode;
		}
		public int PriceCode { get; private set; }
	}
}
