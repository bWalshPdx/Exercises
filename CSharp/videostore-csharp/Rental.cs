using System;

namespace VideoStore
{
	public class Rental
	{
		public Rental(Movie movie, int daysRented)
		{
			this.Movie = movie;
			this.DaysRented = daysRented;
		}

		public int DaysRented { get; }

		public Movie Movie { get; }
	}
}
